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
    public partial class ZamowieniaForm : Form
    {
        private readonly Uzytkownik _uzytkownik;
        List<ZamowienieDto> zamowienia = new List<ZamowienieDto>();
        List<PozycjaZamowieniaDto> produkty = new List<PozycjaZamowieniaDto>();
        public ZamowieniaForm(Uzytkownik uzytkownik)
        {
            InitializeComponent();
            _uzytkownik = uzytkownik;
        }

        private void ZamowieniaForm_Load(object sender, EventArgs e)
        {
            if (_uzytkownik.Zamowienia.Count() > 0)
            {
                foreach (Zamowienie z in _uzytkownik.Zamowienia)
                {
                    zamowienia.Add(new ZamowienieDto
                    {
                        Id = z.Id,
                        Nazwa = $"Zamówienie Id={z.Id}"
                    });
                }
                
                ZamowieniaListBox.DataSource = zamowienia.Select(z => z.Nazwa).ToList();
                ZamowieniaListBox.SelectedIndex = 0;
                LoadProducts();
                ProduktyDataGridView.DataSource = null;
                ProduktyDataGridView.DataSource = produkty;
            }
        }

        private void ZamowieniaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
            ProduktyDataGridView.DataSource = null;
            ProduktyDataGridView.DataSource = produkty;
        }

        private void LoadProducts()
        {
            produkty.Clear();
            foreach (PozycjaZamowienia p in _uzytkownik.Zamowienia[ZamowieniaListBox.SelectedIndex].Produkty)
            {
                produkty.Add(new PozycjaZamowieniaDto
                {
                    Nazwa = p.Produkt.Nazwa,
                    Ilosc = p.Ilosc,
                    Cena = p.Cena,
                    Suma = p.Suma
                });
            }
        }
    }
}
