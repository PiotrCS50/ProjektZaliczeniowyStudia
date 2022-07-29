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
    public partial class DodajMagazynForm : Form, IWalidacjaFormluarza
    {
        private readonly IDataRepository _repository;

        public DodajMagazynForm()
        {
            InitializeComponent();
            _repository = new Repository();
        }

        public event SprawdzPoleTextoweDelegate FormTextCheck;
        public event SprawdzPoleComboDelegate FormComboCheck;

        public async void DodajButton_Click(object sender, EventArgs e)
        {
            _repository.DodajMagazyn(
                new Magazyn
                {
                    Nazwa = NazwaTextBox.Text,
                    Domyslny = CzyDomyslnyCheckBox.Checked,
                    Produkty = new List<PozycjaMagazynu>()
                });
            if (await _repository.ZapiszZmiany()) 
            {
                MessageBox.Show("Magazyn został dodany");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wystąpił błąd");
                this.DialogResult = DialogResult.None;
            } 
        }

        private void NazwaTextBox_TextChanged(object sender, EventArgs e)
        {
            FormTextCheck?.Invoke("Podaj nazwę magazynu", NazwaTextBox, ref WalidacjaNazwaLabel);
            DodajButton.Enabled = WalidacjaNazwaLabel.CausesValidation;
        }

        private void NazwaTextBox_Validating(object sender, CancelEventArgs e)
        {
            FormTextCheck?.Invoke("Podaj nazwę magazynu", NazwaTextBox, ref WalidacjaNazwaLabel);
            DodajButton.Enabled = WalidacjaNazwaLabel.CausesValidation;
        }
    }
}
