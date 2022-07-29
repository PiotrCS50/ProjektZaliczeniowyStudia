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
    public partial class ResetHaslaForm : Form, IWalidacjaFormluarza
    {
        private Uzytkownik _user;
        private readonly IDataRepository _repository;
        public ResetHaslaForm(Uzytkownik user)
        {
            InitializeComponent();
            _user = user;
            _repository = new Repository();
        }

        public event SprawdzPoleTextoweDelegate FormTextCheck;
        public event SprawdzPoleComboDelegate FormComboCheck;

        private void StareHasloTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Podaj stare hasło!", StareHasloTextBox, ref WalidacjaStareHasloLabel);
            Walidacja();
        }

        private void StareHasloTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormTextCheck?.Invoke("Podaj stare hasło!", StareHasloTextBox, ref WalidacjaStareHasloLabel);
            Walidacja();
        }

        private void NoweHasloTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Podaj nowe hasło!", NoweHasloTextBox, ref WalidacjaNoweHasloLabel);
            Walidacja();
        }

        private void NoweHasloTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormTextCheck?.Invoke("Podaj nowe hasło!", NoweHasloTextBox, ref WalidacjaNoweHasloLabel);
            Walidacja();
        }

        private void PowtorzHasloTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Powtórz nowe hasło!", PowtorzHasloTextBox, ref WalidacjaPowtorzHasloLabel);
            Walidacja();
        }

        private void PowtorzHasloTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormTextCheck?.Invoke("Powtórz nowe hasło!", PowtorzHasloTextBox, ref WalidacjaPowtorzHasloLabel);
            Walidacja();
        }
        private void Walidacja()
        {
            if (WalidacjaNoweHasloLabel.CausesValidation && WalidacjaPowtorzHasloLabel.CausesValidation && WalidacjaStareHasloLabel.CausesValidation
                && NoweHasloTextBox.Text.Equals(PowtorzHasloTextBox.Text))
            {
                ZapiszButton.Enabled = true;
            }
            else if (!NoweHasloTextBox.Text.Equals(PowtorzHasloTextBox.Text))
            {
                ZapiszButton.Enabled = false;
                WalidacjaPowtorzHasloLabel.Text = "Hasła róznią się od siebie!";
                WalidacjaPowtorzHasloLabel.Visible = true;
                WalidacjaPowtorzHasloLabel.ForeColor = Color.Red;
            }
            else ZapiszButton.Enabled = false;
        }

        private async void ZapiszButton_Click(object sender, EventArgs e)
        {
            await _repository.ZmienHaslo(_user, StareHasloTextBox.Text, NoweHasloTextBox.Text);
            if (await _repository.ZapiszZmiany()) 
            { 
                MessageBox.Show("Hasło zostało zmienione");
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Stare hasło jest niepoprawne");
        }
    }
}
