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
    public partial class UsunProduktForm : Form
    {
        IDataRepository _repository;
        private readonly Magazyn _magazyn;
        public UsunProduktForm(Magazyn magazyn)
        {
            InitializeComponent();
            _repository = new Repository();
            _magazyn = magazyn;
        }

        private async void UsunProduktForm_Load(object sender, EventArgs e)
        {
            ProduktDataGridView.DataSource = await _repository.DajProduktyWMagazynie(_magazyn.Id);
            LoadDetails();
        }

        private async void UsunButton_Click(object sender, EventArgs e)
        {
            ProduktDto wybrany = (ProduktDto)ProduktDataGridView.CurrentRow.DataBoundItem;
            _repository.UsunProduktZMagazynu(_magazyn.Id,wybrany);
            await _repository.ZapiszZmiany();
            ProduktDataGridView.DataSource = await _repository.DajProduktyWMagazynie(_magazyn.Id);

        }

        private async void SzukajTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SzukajTextBox.Text)) ProduktDataGridView.DataSource = await _repository.DajProduktyWMagazynie(_magazyn.Id);
            else ProduktDataGridView.DataSource =await _repository.DajPrzefiltrowaneProdukty
                       (_magazyn.Id,p => p.Produkt.Nazwa.ToLower().Contains(SzukajTextBox.Text.ToLower())); 
        }

        private void ProduktDataGridView_Click(object sender, EventArgs e)
        {
            LoadDetails();
        }
        private void LoadDetails()
        {
            ProduktDto wybrany = (ProduktDto)ProduktDataGridView.CurrentRow?.DataBoundItem;
            if (wybrany != null)
            {
                opisTtextBox.Text = wybrany.Opis;
                NazwaLabel.Text = wybrany.Nazwa;
                KategoriaValueLabel.Text = wybrany.Kategoria;
            }
        }
    }
}
