using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    public interface IDataRepository
    {
        void DodajMagazyn(Magazyn magazyn);
        void UsunMagazyn(Magazyn magazyn);
        void UstawMagazynJakoDomyslny(int IdMagazynu);
        Task<Magazyn> DajMagazyn();
        Task<List<Magazyn>> DajMagazyny();
        Task<List<ProduktDto>> DajProduktyWMagazynie(int IdMagazynu);
        Task<IEnumerable<ProduktDto>> DajPrzefiltrowaneProdukty(int IdMagazynu, Func<PozycjaMagazynu, bool> filter);

        Task<IEnumerable<Kategoria>> DajKategorie();
        Task<Kategoria> DajKategoriePoNazwie(string nazwa);
        void UsunProduktZMagazynu(int IdMagazynu,ProduktDto produkt);
        void DodajProdukt(int IdMagazynu, Produkt produkt, int ilosc, decimal cena);
        void UsunKategorie(Kategoria kategoria);
        void DodajKategorie(Kategoria kategoria);
        Task<bool> AktualizujProdukt(int IdMagazynu, ProduktDto produktDto, string staraNazwa);
        Task EdytujUzytkownika(Uzytkownik user);
        Task ZmienHaslo(Uzytkownik user, string stareHaslo, string noweHaslo);
        bool DodajDoKoszyka(int IdMagazynu, Uzytkownik uzytkownik, ProduktDto produktDto);
        bool UsunZKoszyka(Uzytkownik uzytkownik, PozycjaKoszykaDto pozycja);
        Task ZrealizujZakup(Uzytkownik user, int magazynId);
        Uzytkownik Zaloguj(string nazwa, string haslo);
        bool DodajUzytkownika(Uzytkownik uzytkownik);
        void DoladujKonto(Uzytkownik user, decimal kwota);
        Task<bool> ZapiszZmiany();
        void Odswierz();
        Uzytkownik WczytajUzytkownika(Uzytkownik user);
    }
}
