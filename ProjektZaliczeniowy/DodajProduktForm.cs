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
    public partial class DodajProduktForm : Form, IWalidacjaFormluarza
    {

        IDataRepository _repository;
        private readonly Magazyn _magazyn;

        public event SprawdzPoleTextoweDelegate FormTextCheck;
        public event SprawdzPoleComboDelegate FormComboCheck;

        public DodajProduktForm(Magazyn magazyn)
        {
            InitializeComponent();
            _repository = new Repository();
            _magazyn = magazyn;
        }
        private async void DodajProduktForm_Load(object sender, EventArgs e)
        {
            var kat = await _repository.DajKategorie();
            KategoriaComboBox.Items.AddRange(kat.ToArray());
        }

        // Działania na button
        private async void DodajButton_Click(object sender, EventArgs e)
        {
            DodajButton.Enabled = true;
            decimal cena;
            Decimal.TryParse(CenaTextBox.Text, out cena);
            _repository.DodajProdukt(_magazyn.Id,
                new Produkt
                {
                    Nazwa = NazwaTextBox.Text,
                    Opis = OpisTextBox.Text,
                    Kategoria = await _repository.DajKategoriePoNazwie(KategoriaComboBox.Text),
                }
            , (int)IloscNumericUpDown.Value, cena);
            if (await _repository.ZapiszZmiany()) MessageBox.Show("Produkt został dodany");
        }

        //Działania na cena
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

        private void CenaTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormTextCheck?.Invoke("Wpisz cenę produktu", CenaTextBox, ref WalidacjaCenaLabel);
            ButtonValidate();
        }
        private void CenaTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Wpisz cenę produktu", CenaTextBox, ref WalidacjaCenaLabel);
            ButtonValidate();
        }

        //Działania na Nazwa
        private void NazwaTextBox_Validating(object sender, CancelEventArgs e)
        {

            FormTextCheck?.Invoke("Podaj nazwę produktu", NazwaTextBox, ref WalidacjaNazwaLabel);
            ButtonValidate();
        }
        private void NazwaTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Podaj nazwę produktu", NazwaTextBox, ref WalidacjaNazwaLabel);
            ButtonValidate();
        }

        //Działania na Kategoria
        private void KategoriaComboBox_Validating(object sender, CancelEventArgs e)
        {

            FormComboCheck?.Invoke("Wpisz kategorię produktu", KategoriaComboBox, ref WalidacjaKategoriaLabel);
            ButtonValidate();
        }
        private void KategoriaComboBox_TextChanged(object sender, EventArgs e)
        {
            FormComboCheck?.Invoke("Wpisz kategorię produktu", KategoriaComboBox, ref WalidacjaKategoriaLabel);
            ButtonValidate();
        }

        //Działania na Opis
        private void OpisTextBox_Validating(object sender, CancelEventArgs e)
        {

            FormTextCheck?.Invoke("Podaj opis produktu", OpisTextBox, ref WalidacjaOpisLabel);
            ButtonValidate();
        }

        private void OpisTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Podaj opis produktu", OpisTextBox, ref WalidacjaOpisLabel);
            ButtonValidate();
        }

        //Działania na Ilosc
        private void IloscNumericUpDown_Validating(object sender, CancelEventArgs e)
        {
            ButtonValidate();
        }

        //Funkcje prywatne własne
        private bool ButtonValidate()
        {
            if (WalidacjaNazwaLabel.CausesValidation && WalidacjaKategoriaLabel.CausesValidation &&
                WalidacjaOpisLabel.CausesValidation && WalidacjaCenaLabel.CausesValidation &&
                WalidacjaIloscLabel.CausesValidation)
            {
                DodajButton.Enabled = true;
                return true;
            }
            else
            {
                DodajButton.Enabled = false;
                return false;
            }
        }
    }
}
