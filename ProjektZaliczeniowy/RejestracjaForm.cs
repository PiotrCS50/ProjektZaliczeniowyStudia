using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    public partial class RejestracjaForm : Form,IWalidacjaFormluarza
    {
        private readonly IDataRepository _repository;

        public RejestracjaForm()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public event SprawdzPoleTextoweDelegate FormTextCheck;
        public event SprawdzPoleComboDelegate FormComboCheck;

        private void NazwaTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormTextCheck?.Invoke("Wpisz swoją nazwę", NazwaTextBox, ref WalidacjaNazwaLabel);
        }

        private void ImieTextBox_Validating(object sender, CancelEventArgs e)
        {

            FormTextCheck?.Invoke("Wpisz swoje imie", ImieTextBox, ref WalidacjaImieLabel);

        }

        private void NazwiskoTextBox_Validating(object sender, CancelEventArgs e)
        {

            FormTextCheck?.Invoke("Wpisz swoje nazwisko", NazwiskoTextBox, ref WalidacjaNazwiskoLabel);

        }

        private void HasloTextBox_Validating(object sender, CancelEventArgs e)
        {

            FormTextCheck?.Invoke("Wpisz hasło", HasloTextBox, ref WalidacjaHasloLabel);

        }

        private async void rejetracjaButton_Click(object sender, EventArgs e)
        {
            if (WalidacjaNazwaLabel.CausesValidation && WalidacjaImieLabel.CausesValidation && WalidacjaHasloLabel.CausesValidation)
            {
                var hmac = new HMACSHA512();
                Uzytkownik user = new Uzytkownik
                {
                    Nazwa = NazwaTextBox.Text,
                    Imie = ImieTextBox.Text,
                    Nazwisko = NazwiskoTextBox.Text,
                    HasloHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(HasloTextBox.Text)),
                    HasloSalt = hmac.Key,
                    Pieniadze = 0,
                    TypKonta = "Standard",
                    Koszyk = new Koszyk { Produkty = new List<PozycjaKoszyka>() },
                    Zamowienia = new List<Zamowienie>()
                };
                if (!_repository.DodajUzytkownika(user)) MessageBox.Show("Ta nazwa użytkownika jest zajęta");
                else
                    if (await _repository.ZapiszZmiany())
                {
                    MessageBox.Show("Zostałeś zarejetrowany.\nMożesz się już zalogować");
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                this.DialogResult = DialogResult.None;
                Close();
            }
        }
    }
}
