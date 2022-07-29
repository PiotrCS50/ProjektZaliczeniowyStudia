using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    public partial class LogowanieForm : Form, IWalidacjaFormluarza
    {
        private Uzytkownik _uzytkownik;
        private readonly IDataRepository _repository;

        public LogowanieForm()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public event SprawdzPoleTextoweDelegate FormTextCheck;
        public event SprawdzPoleComboDelegate FormComboCheck;

        private void ZalogujButton_Click(object sender, EventArgs e)
        {
            Uzytkownik response;
            if (WalidacjaNazwaLabel.CausesValidation && walidacjaHasloLabel.CausesValidation)
            {
                response = _repository.Zaloguj(NazwaTextBox.Text, HasloTextBox.Text);
                if (response == null)
                {
                    Thread message = new Thread(Wiadomosc);
                    message.Start();
                }
                else
                {
                    _uzytkownik = response;
                    this.DialogResult = DialogResult.OK;
                }
            }

        }

        private void NazwaTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormTextCheck?.Invoke("Wpisz swoją nazwę", NazwaTextBox, ref WalidacjaNazwaLabel);
            Walidacja();
        }

        private void HasloTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormTextCheck?.Invoke("Wpisz hasło", HasloTextBox, ref walidacjaHasloLabel);
            Walidacja();
        }

        private void RejestracjaButton_Click(object sender, EventArgs e)
        {
            RejestracjaForm rejestracja = new RejestracjaForm();
            var validator = new FormValidator(rejestracja);
            rejestracja.ShowDialog();
        }

        private void Walidacja()
        {
            if (WalidacjaNazwaLabel.CausesValidation && walidacjaHasloLabel.CausesValidation)
            {
                ZalogujButton.Enabled = true;
            }
            else ZalogujButton.Enabled = false;
        }

        private void NazwaTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Wpisz swoją nazwę", NazwaTextBox, ref WalidacjaNazwaLabel);
            Walidacja();
        }

        private void HasloTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Wpisz hasło", HasloTextBox, ref walidacjaHasloLabel);

            Walidacja();
        }
        private void Wiadomosc()
        {
            MessageBox.Show("Nazwa użytkownika lub hasło są niepoprawne!\nMusiz być zalogowany!");
        }

        public Uzytkownik PrzekazUzytkownika()
        {
            return _uzytkownik;
        }

    }
}
