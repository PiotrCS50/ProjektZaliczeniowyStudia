using System;
using System.Data.Entity;
using System.Linq;

namespace ProjektZaliczeniowy
{
    public class BazaSklepKomputerowy : DbContext
    {
        public BazaSklepKomputerowy()
            : base("name=BazaSklepKomputerowyServer")
        {
        }

        public DbSet<Magazyn> Magazyny { get; set; }
        public DbSet<Produkt> Produkty { get; set; }
        public DbSet<Uzytkownik> U¿ytkownicy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<Koszyk> Koszyki { get; set; }
    }
}