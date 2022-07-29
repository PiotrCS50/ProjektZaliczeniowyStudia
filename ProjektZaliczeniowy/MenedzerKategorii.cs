using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    class MenedzerKategorii
    {
        private readonly IDataRepository _repository;
        string nazwaKategorii;
        Kategoria kategoria;
        UsunEdytujMagazynForm usunEdytujForm;
        DodajMagazynForm dodajForm;
        public MenedzerKategorii()
        {
            _repository = new Repository();
        }

        public async Task<bool> DodajKategorie()
        {
            dodajForm = new DodajMagazynForm();
            new FormValidator(dodajForm);
            dodajForm.TytulLabel.Text = "Dodaj kategorię";
            dodajForm.CzyDomyslnyCheckBox.Visible = false;
            dodajForm.DodajButton.Click -= dodajForm.DodajButton_Click;
            dodajForm.DodajButton.Click += DodajButton_Click;
            dodajForm.DodajButton.DialogResult = DialogResult.OK;
            if(dodajForm.ShowDialog() == DialogResult.OK)
            {
                await _repository.ZapiszZmiany();
                return true;
            }
            return false;
        }

        public async Task<bool> UsunEdytujKategorie()
        {
            usunEdytujForm = new UsunEdytujMagazynForm();
            usunEdytujForm.TytulLabel.Text = "Usuń / Edytuj kategorię";
            usunEdytujForm.Load -= usunEdytujForm.UsunEdytujMagazynForm_Load;
            usunEdytujForm.MagazynyDataGridView.DataSource = await _repository.DajKategorie();
            usunEdytujForm.UsunButton.Click -= usunEdytujForm.UsunButton_Click;
            usunEdytujForm.EdytujButton.Click -= usunEdytujForm.EdytujButton_Click;
            usunEdytujForm.UsunButton.Click += UsunButton_Click;
            usunEdytujForm.EdytujButton.Click += EdytujButton_Click;
            if(usunEdytujForm.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        private async void EdytujButton_Click(object sender, EventArgs e)
        {
            kategoria = (Kategoria)usunEdytujForm.MagazynyDataGridView.CurrentRow.DataBoundItem;
            dodajForm = new DodajMagazynForm();
            new FormValidator(dodajForm);
            dodajForm.TytulLabel.Text = "Edytuj kategorię";
            dodajForm.DodajButton.DialogResult = DialogResult.OK;
            dodajForm.NazwaTextBox.Text = kategoria.Nazwa;
            dodajForm.CzyDomyslnyCheckBox.Visible = false;
            dodajForm.DodajButton.Text = "Edytuj";
            dodajForm.DodajButton.Click -= dodajForm.DodajButton_Click;
            dodajForm.DodajButton.Click += ZapiszEdycjeButton_Click;
            if (dodajForm.ShowDialog() == DialogResult.OK)
                if (!await _repository.ZapiszZmiany()) MessageBox.Show("Kategoria zmienniona");
            _repository.Odswierz();
            usunEdytujForm.MagazynyDataGridView.DataSource = await _repository.DajKategorie();
        }

        private async void ZapiszEdycjeButton_Click(object sender, EventArgs e)
        {
            //kategoria.Nazwa = dodajForm.NazwaTextBox.Text;
            var kat = await _repository.DajKategoriePoNazwie(kategoria.Nazwa);
            kat.Nazwa = dodajForm.NazwaTextBox.Text;
            await _repository.ZapiszZmiany();
        }

        private async void UsunButton_Click(object sender, EventArgs e)
        {
            kategoria = (Kategoria)usunEdytujForm.MagazynyDataGridView.CurrentRow.DataBoundItem;
            _repository.UsunKategorie(kategoria);
            if (await _repository.ZapiszZmiany()) MessageBox.Show("Kategoria została usunięta");
            else MessageBox.Show("Nie można usunąć kategorii.\nIstnieją produkty posiadające te kategorię.");
            usunEdytujForm.MagazynyDataGridView.DataSource =await _repository.DajKategorie();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            nazwaKategorii = dodajForm.NazwaTextBox.Text;
            _repository.DodajKategorie(new Kategoria
            {
                Nazwa = nazwaKategorii
            });
        }
    }
}
