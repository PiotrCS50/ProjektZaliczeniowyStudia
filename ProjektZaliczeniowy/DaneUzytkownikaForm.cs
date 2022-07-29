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
    public partial class DaneUzytkownikaForm : Form, IWalidacjaFormluarza
    {
        private Uzytkownik _user;
        private readonly IDataRepository _repository;
        public DaneUzytkownikaForm(Uzytkownik user)
        {
            InitializeComponent();
            _user = user;
            _repository = new Repository();
        }

        public event SprawdzPoleTextoweDelegate FormTextCheck;
        public event SprawdzPoleComboDelegate FormComboCheck;

        private void DaneUzytkownikaForm_Load(object sender, EventArgs e)
        {
            TytulLabel.Text = _user.Imie + " " + _user.Nazwisko;
            NazwaTextBox.Text = _user.Nazwa;
            ImieTextBox.Text = _user.Imie;
            NazwiskoTextBox.Text = _user.Nazwisko;
        }

        private async void ZapiszButton_Click(object sender, EventArgs e)
        {
            _user.Nazwa = NazwaTextBox.Text;
            _user.Nazwisko = NazwiskoTextBox.Text;
            _user.Imie = ImieTextBox.Text;
            await _repository.EdytujUzytkownika(_user);
            if (await _repository.ZapiszZmiany()) MessageBox.Show("Twoje dane zostały zmienione");
        }

        private void NazwaTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormTextCheck?.Invoke("Nazwa jest wymagana!", NazwaTextBox, ref WalidacjaNazwaLabel);
            Walidacja();
        }

        private void NazwaTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Nazwa jest wymagana!", NazwaTextBox, ref WalidacjaNazwaLabel);
            Walidacja();
        }

        private void ImieTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormTextCheck?.Invoke("Wpisz swoje imie!", ImieTextBox, ref WalidacjaImieLabel);
            Walidacja();
        }

        private void ImieTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Wpisz swoje imie!", ImieTextBox, ref WalidacjaImieLabel);
            Walidacja();
        }

        private void NazwiskoTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormTextCheck?.Invoke("Wpisz swoje nazwisko!", NazwiskoTextBox, ref WalidacjaNazwiskoLabel);
            Walidacja();
        }

        private void NazwiskoTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Wpisz swoje nazwisko!", NazwiskoTextBox, ref WalidacjaNazwiskoLabel);
            Walidacja();
        }

        private void Walidacja()
        {
            if (WalidacjaImieLabel.CausesValidation && WalidacjaNazwiskoLabel.CausesValidation && WalidacjaNazwaLabel.CausesValidation)
            {
                ZapiszButton.Enabled = true;
            }
            else ZapiszButton.Enabled = false;

        }
    }
}
