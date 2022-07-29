using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    public partial class SklepForm : Form
    {
        Magazyn magazyn;
        Repository repository;
        Uzytkownik uzytkownik;
        public SklepForm()
        {
            InitializeComponent();
        }

        private async void SklepForm_Load(object sender, EventArgs e)
        {
            repository = new Repository();
            LogowanieForm logowanie = new LogowanieForm();
            var validator = new FormValidator(logowanie);
            if (logowanie.ShowDialog() == DialogResult.OK)
            {
                magazyn = await repository.DajMagazyn();
                if (magazyn == null)
                {
                    MessageBox.Show("Brak magazynu!\nDodaj magazyn!");
                    var mag = new DodajMagazynForm();
                    new FormValidator(mag);
                    if (mag.ShowDialog() == DialogResult.OK)
                    {
                        magazyn = await repository.DajMagazyn();
                    }
                }
                if (magazyn != null)
                {
                    uzytkownik = logowanie.PrzekazUzytkownika();
                    if (uzytkownik.TypKonta != "Administrator") administracjaToolStripMenuItem.Visible = false;
                    else administracjaToolStripMenuItem.Visible = true;
                    PieniadzeLabel.Text = uzytkownik.Pieniadze.ToString("c");
                    LoadProducts();
                    LoadKategories();
                    await Task.Delay(10);
                    LoadDetails();
                }
            }
            else Close();
            if (magazyn == null) Close();
        }

        private void ProduktDataGridView_Click(object sender, EventArgs e)
        {
            IloscNumericUpDown.Value = 1;
            LoadDetails();
        }


        private void IloscNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ProduktDataGridView.RowCount > 0)
            {
                ProduktDto wybrany = (ProduktDto)ProduktDataGridView.CurrentRow.DataBoundItem;
                if (IloscNumericUpDown.Value >= wybrany.Ilosc) IloscNumericUpDown.Value = wybrany.Ilosc;
                SumaLabel.Text = (wybrany.Cena * IloscNumericUpDown.Value).ToString("c");
            }
        }

        private async void KategorieListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((string)KategorieListBox.SelectedItem == "Wszystkie") KategorieListBox.SelectedItem = null;
            LoadProducts();
            await Task.Delay(10);
            LoadDetails();
        }

        private void CenaDoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            LoadProducts ();
        }

        private void CenaOdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private async void dodajProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DodajForm = new DodajProduktForm(magazyn);
            new FormValidator(DodajForm);
            if(DodajForm.ShowDialog() == DialogResult.OK)
            {
                await Task.Delay(10);
                LoadProducts();
                LoadDetails();
            }
        }
        private void usuńProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsunProduktForm usunForm = new UsunProduktForm(magazyn);
            usunForm.ShowDialog();
            LoadProducts();
            LoadDetails();
        }

        private async void edytujProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProduktDataGridView.RowCount > 0)
            {
                ProduktDto wybrany = (ProduktDto)ProduktDataGridView.CurrentRow.DataBoundItem;
                EdytujProduktForm edytujProdukt = new EdytujProduktForm(wybrany, magazyn);
                var validator = new FormValidator(edytujProdukt);
                if (edytujProdukt.ShowDialog() == DialogResult.OK)
                {
                    await Task.Delay(20);
                    LoadProducts();
                    LoadDetails();
                }
            }
        }

        private async void DodajDoKoszaButton_Click(object sender, EventArgs e)
        {
            if (ProduktDataGridView.RowCount > 0)
            {
                ProduktDto wybrany = (ProduktDto)ProduktDataGridView.CurrentRow.DataBoundItem;
                ProduktDto doKoszyka = new ProduktDto
                {
                    Cena = wybrany.Cena,
                    Ilosc = (int)IloscNumericUpDown.Value,
                    Nazwa = wybrany.Nazwa,
                    Kategoria = wybrany.Kategoria,
                    Opis = wybrany.Opis
                };
                var resp = repository.DodajDoKoszyka(magazyn.Id, uzytkownik, doKoszyka);
                if (resp == true && await repository.ZapiszZmiany())
                    MessageBox.Show($"Produkt {wybrany.Nazwa} został dodany do koszyka");
                else if (resp == true) MessageBox.Show($"Ilość produtku {wybrany.Nazwa} została zwiększona");
                else MessageBox.Show($"Chcesz dodać za dużą ilość tego produktu. \n {wybrany.Nazwa} jest już w koszyku.");
                Odswierz();
            }
        }

        private async void koszykToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odswierz();
            KoszykForm koszyk = new KoszykForm(uzytkownik, magazyn.Id);
            if(koszyk.ShowDialog() == DialogResult.OK)
            {
                await Task.Delay(10);
                LoadProducts();
                PieniadzeLabel.Text = uzytkownik.Pieniadze.ToString("c");
            }
        }

        private void zamówieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odswierz();
            ZamowieniaForm zamowieniaForm = new ZamowieniaForm(uzytkownik);
            zamowieniaForm.ShowDialog();
        }

        private void dodajMagazynToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dodajMag = new DodajMagazynForm();
            new FormValidator(dodajMag);
            dodajMag.ShowDialog();
            LoadProducts();
            LoadDetails();
        }

        private void UsunEtytujMagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsunEdytujMagazynForm form = new UsunEdytujMagazynForm();
            form.ShowDialog();
            LoadProducts();
            LoadDetails();
        }

        private async void dodajKatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenedzerKategorii menedzer = new MenedzerKategorii();
            if (await menedzer.DodajKategorie())
            {
                Odswierz();
                LoadKategories();
            }

        }

        private async void usunEdytujKatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenedzerKategorii menedzer = new MenedzerKategorii();
            if (!await menedzer.UsunEdytujKategorie())
            {
                Odswierz();
                LoadKategories();
            }

        }

        private async void doladujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doladuj form = new Doladuj(uzytkownik);
            form.ShowDialog();
            await Task.Delay(10);
            Odswierz();
            PieniadzeLabel.Text = uzytkownik.Pieniadze.ToString("c");
        }


        private void daneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaneUzytkownikaForm form = new DaneUzytkownikaForm(uzytkownik);
            new FormValidator(form);
            form.ShowDialog();
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SklepForm_Load(sender, e);
        }


        private void ZresetujHasloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetHaslaForm form = new ResetHaslaForm(uzytkownik);
            new FormValidator(form);
            form.ShowDialog();
        }
        private async void LoadProducts()
        {
            ProduktDataGridView.DataSource = null;
            Odswierz();
                ProduktDataGridView.DataSource = await repository.DajPrzefiltrowaneProdukty(magazyn.Id, p =>
                {
                    if (p.Ilosc > 0 && p.Cena >= CenaOdNumericUpDown.Value && p.Cena <= CenaDoNumericUpDown.Value && (KategorieListBox.SelectedItem == null || p.Produkt.Kategoria.Nazwa == (string)KategorieListBox?.SelectedItem))
                        return true;
                    return false;
                });
        }

        private void LoadDetails()
        {
            if (ProduktDataGridView.Rows.Count > 0)
            {
                ProduktDto wybrany = (ProduktDto)ProduktDataGridView.CurrentRow?.DataBoundItem;
                if (wybrany != null)
                {
                    CenaLabel.Text = wybrany.Cena.ToString("c");
                    SumaLabel.Text = (wybrany.Cena * IloscNumericUpDown.Value).ToString("c");
                    OpisTextBox.Text = wybrany.Opis;
                    NazwaLabel.Text = wybrany.Nazwa;
                }
            }
            else
            {
                CenaLabel.Text = 0.ToString("c");
                SumaLabel.Text = 0.ToString("c");
                OpisTextBox.Text = "";
                NazwaLabel.Text = "";
            }
        }
        private async void LoadKategories()
        {
            repository.Odswierz();
            List<string> kategorieNazwy = new List<string>();
            kategorieNazwy.Add("Wszystkie");
            foreach (Kategoria k in await repository.DajKategorie())
            {
                kategorieNazwy.Add(k.Nazwa);
            }
            KategorieListBox.DataSource = kategorieNazwy;
            KategorieListBox.SelectedItem = "Wszystkie";
        }

        private void Odswierz()
        {
            repository.Odswierz();
            uzytkownik = repository.WczytajUzytkownika(uzytkownik);
        }

    }
}
