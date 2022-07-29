using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    public partial class KoszykForm : Form
    {
        private Uzytkownik _uzytkownik;
        private readonly IDataRepository _repository;
        private List<PozycjaKoszykaDto> _produkty = new List<PozycjaKoszykaDto>();
        private readonly int _magazynId;

        public KoszykForm(Uzytkownik uzytkownik, int magazynId)
        {
            InitializeComponent();
            _uzytkownik = uzytkownik;
            _repository = new Repository();
            _magazynId = magazynId;
        }

        private void KoszykForm_Load(object sender, EventArgs e)
        {
            
            if(_uzytkownik.Koszyk != null)
            {
                WczytajKoszyk();
            }
            _uzytkownik.Koszyk.LacznaSuma = PoliczSume();
            _repository.ZapiszZmiany();
            SumaWartoscLabel.Text = _uzytkownik.Koszyk.LacznaSuma.ToString("c");
        }

        private async void KoszykDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                _repository.UsunZKoszyka(_uzytkownik, (PozycjaKoszykaDto)KoszykDataGridView.CurrentRow.DataBoundItem);
                KoszykDataGridView.DataSource = null;
                await _repository.ZapiszZmiany();
                WczytajKoszyk();
                _uzytkownik.Koszyk.LacznaSuma = PoliczSume();
                await _repository.ZapiszZmiany();
                SumaWartoscLabel.Text = _uzytkownik.Koszyk.LacznaSuma.ToString("c");

            }
        }

        private async void KupButton_Click(object sender, EventArgs e)
        {
            await _repository.ZrealizujZakup(_uzytkownik, _magazynId);
            ZakupyZrealizowaneForm potwierdzenie = new ZakupyZrealizowaneForm();
            if (await _repository.ZapiszZmiany())
            {
                potwierdzenie.Paint += potwierdzenie.Ok_Paint;
                potwierdzenie.TimerOk.Enabled = true;
                potwierdzenie.TimerBad.Enabled = false;
                potwierdzenie.ShowDialog();
            }
            else
            {
                potwierdzenie.Paint += potwierdzenie.Bad_Paint;
                potwierdzenie.TimerBad.Enabled = true;
                potwierdzenie.TimerOk.Enabled = false;
                if (_uzytkownik.Pieniadze < _uzytkownik.Koszyk.LacznaSuma)
                {
                    potwierdzenie.InfoLabel.Visible = true;
                    potwierdzenie.InfoLabel.Text = "Brak wystarczającej ilości środków na koncie";
                }
                else
                {
                    potwierdzenie.InfoLabel.Visible = true;
                    potwierdzenie.InfoLabel.Text = "Przepraszamy, wystąpił błąd. Spróbuj później";
                }
                potwierdzenie.ShowDialog();
            }
            this.DialogResult = DialogResult.OK;
            Close();

        }
        private void WczytajKoszyk()
        {
            _repository.Odswierz();
            _uzytkownik = _repository.WczytajUzytkownika(_uzytkownik);
            _produkty.Clear();
            foreach (PozycjaKoszyka poz in _uzytkownik.Koszyk.Produkty)
            {
                _produkty.Add(new PozycjaKoszykaDto
                {
                    NazwaProduktu = poz.Produkt.Nazwa,
                    Ilosc = poz.Ilosc,
                    Cena = poz.Cena,
                    Suma = poz.Suma,
                    PozycjaKoszykaId = poz.Id
                });
            }
            KoszykDataGridView.DataSource = null;
            KoszykDataGridView.DataSource = _produkty;
        }
        private decimal PoliczSume()
        {
            return _uzytkownik.Koszyk.Produkty.Sum(s => s.Cena * s.Ilosc);
        }
    }
}
