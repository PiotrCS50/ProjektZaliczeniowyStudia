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
    public partial class EdytujProduktForm : Form, IWalidacjaFormluarza
    {
        ProduktDto _produkt;
        IDataRepository _repository;
        private readonly Magazyn _magazyn;

        public event SprawdzPoleTextoweDelegate FormTextCheck;
        public event SprawdzPoleComboDelegate FormComboCheck;

        public EdytujProduktForm(ProduktDto produkt, Magazyn magazyn)
        {
            InitializeComponent();
            _produkt = produkt;
            _repository = new Repository();
            _magazyn = magazyn;
        }

        private void CenaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private async void EdytujProduktForm_Load(object sender, EventArgs e)
        {
            NazwaTextBox.Text = _produkt.Nazwa;
            OpisTextBox.Text = _produkt.Opis;
            var kategorie = await _repository.DajKategorie();
            KategoriaComboBox.Items.AddRange(kategorie.ToArray());
            KategoriaComboBox.SelectedItem = await _repository.DajKategoriePoNazwie(_produkt.Kategoria);
            CenaTextBox.Text = _produkt.Cena.ToString();
            IloscNumericUpDown.Value = _produkt.Ilosc;
        }

        private async void EdytujButton_Click(object sender, EventArgs e)
        {
            if (WalidacjaButton())
            {
                string staraNazwa = _produkt.Nazwa;
                _produkt.Nazwa = NazwaTextBox.Text;
                _produkt.Opis = OpisTextBox.Text;
                _produkt.Kategoria = KategoriaComboBox.SelectedItem.ToString();
                _produkt.Ilosc = (int)IloscNumericUpDown.Value;
                decimal cena;
                decimal.TryParse(CenaTextBox.Text, out cena);
                _produkt.Cena = cena;
                await _repository.AktualizujProdukt(_magazyn.Id, _produkt, staraNazwa);
                if(await _repository.ZapiszZmiany()) MessageBox.Show("Produkt został edytowany pomyślnie.");
                else MessageBox.Show("Błąd przy edycji.\nZmiany nie zostały wprowadzone");
            }
        }

        private void NazwaTextBox_Validating(object sender, CancelEventArgs e)
        {

            FormTextCheck?.Invoke("Podaj nazwę produktu", NazwaTextBox, ref WalidacjaNazwaLabel);
            WalidacjaButton();
        }

        private void KategoriaComboBox_Validating(object sender, CancelEventArgs e)
        {

            FormComboCheck?.Invoke("Wpisz kategorię produktu", KategoriaComboBox, ref WalidacjaKategoriaLabel);
            WalidacjaButton();
        }

        private void OpisTextBox_Validating(object sender, CancelEventArgs e)
        {

            FormTextCheck?.Invoke("Podaj opis produktu", OpisTextBox, ref WalidacjaOpisLabel);
            WalidacjaButton();
        }

        private void CenaTextBox_Validating(object sender, CancelEventArgs e)
        {

            FormTextCheck?.Invoke("Wpisz cenę produktu", CenaTextBox, ref WalidacjaCenaLabel);
            WalidacjaButton();
        }

        private bool WalidacjaButton()
        {
            if (WalidacjaCenaLabel.CausesValidation && WalidacjaKategoriaLabel.CausesValidation &&
                WalidacjaNazwaLabel.CausesValidation && WalidacjaOpisLabel.CausesValidation)
            {
                EdytujButton.Enabled = true;
                return true;
            }
            EdytujButton.Enabled = false;
            return false;
        }
    }
}
