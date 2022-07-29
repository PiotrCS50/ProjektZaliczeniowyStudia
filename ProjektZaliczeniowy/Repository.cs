using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    public class Repository : IDataRepository
    {
        BazaSklepKomputerowy _dataContext = new BazaSklepKomputerowy();
        public Repository()
        {
        }
        //Magazyn
        public void DodajMagazyn(Magazyn magazyn)
        {
            int bobo =_dataContext.Magazyny.Count();
            if (_dataContext.Magazyny.Count() == 0)
            {
                magazyn.Domyslny = true;
            }
            else if (magazyn.Domyslny)
            {
                _dataContext.Magazyny.SingleOrDefault(m => m.Domyslny == true).Domyslny = false;
            }
            _dataContext.Magazyny.Add(magazyn);
        }

        public void UsunMagazyn(Magazyn magazyn)
        {
            if(_dataContext.Magazyny.Count() > 1 && magazyn.Domyslny == false)
                _dataContext.Magazyny.Remove(magazyn);
        }

        public void UstawMagazynJakoDomyslny(int IdMagazynu)
        {
            _dataContext.Magazyny.SingleOrDefault(m => m.Domyslny == true).Domyslny = false;
            var mag = _dataContext.Magazyny.SingleOrDefault(m => m.Id == IdMagazynu);
            mag.Domyslny = true;
        }
        public async Task<Magazyn> DajMagazyn()
        {
            return await _dataContext.Magazyny.SingleOrDefaultAsync(m => m.Domyslny == true);
        }

        public async Task<List<Magazyn>> DajMagazyny()
        {
            return await _dataContext.Magazyny.ToListAsync();
        }
        //Kategorie
        public async Task<IEnumerable<Kategoria>> DajKategorie()
        {
            return await _dataContext.Kategorie.ToListAsync();
        }

        public async Task<Kategoria> DajKategoriePoNazwie(string nazwa)
        {
            return await _dataContext.Kategorie.Where(k => k.Nazwa == nazwa).FirstOrDefaultAsync();
        }

        public void UsunKategorie(Kategoria kategoria)
        {
            if(!_dataContext.Produkty.Any(p => p.Kategoria.Nazwa == kategoria.Nazwa))
            _dataContext.Kategorie.Remove(kategoria);
        }

        public void DodajKategorie(Kategoria kategoria)
        {
            _dataContext.Kategorie.Add(kategoria);
        }
        //Zamówienia
        public async Task ZrealizujZakup(Uzytkownik user, int magazynId)
        {
            var magazyn = await _dataContext.Magazyny.Include(m => m.Produkty.Select(pr => pr.Produkt)).SingleOrDefaultAsync(m => m.Id == magazynId);
            List<PozycjaZamowienia> zamowienie = new List<PozycjaZamowienia>() ;
            var uzytkownik = await _dataContext.Użytkownicy.Include(u => u.Koszyk.Produkty.Select(pr => pr.Produkt)).Include(u => u.Zamowienia.Select(z => z.Produkty.Select(pr => pr.Produkt))).
                SingleOrDefaultAsync(u => u.Id == user.Id);
            if (user.Pieniadze >= user.Koszyk.LacznaSuma)
            {
                user.Pieniadze -= user.Koszyk.LacznaSuma;
                foreach (PozycjaKoszyka pk in uzytkownik.Koszyk.Produkty)
                {
                    zamowienie.Add(new PozycjaZamowienia
                    {
                        Produkt = pk.Produkt,
                        Ilosc = pk.Ilosc,
                        Cena = pk.Cena,
                        Suma = pk.Suma
                    });
                    magazyn.Produkty.Where(p => p.Id == pk.Produkt.Id).SingleOrDefault().Ilosc -= pk.Ilosc;
                }
                uzytkownik.Zamowienia.Add(new Zamowienie
                {
                    Produkty = zamowienie,
                    Uzytkownik = uzytkownik
                });
                uzytkownik.Koszyk.Produkty.RemoveAll(p => p.Ilosc > 0);
            }

        }
        //Produkty
        public async Task<List<ProduktDto>> DajProduktyWMagazynie(int IdMagazynu)
        {
            var magazyn = await _dataContext.Magazyny.Include(p => p.Produkty.Select(pr => pr.Produkt).Select(pro => pro.Kategoria)).SingleOrDefaultAsync(m => m.Id == IdMagazynu);
            if (magazyn.Produkty.Count() > 0)
            {
                return magazyn.Produkty.Select(p => new ProduktDto
                {
                    Nazwa = p.Produkt.Nazwa,
                    Opis = p.Produkt.Opis,
                    Cena = p.Cena,
                    Kategoria = p.Produkt.Kategoria.Nazwa,
                    Ilosc = p.Ilosc
                }).ToList();
            }
            else return null;
        }

        public async Task<IEnumerable<ProduktDto>> DajPrzefiltrowaneProdukty(int IdMagazynu, Func<PozycjaMagazynu, bool> filter)
        {
            var magazyn = await _dataContext.Magazyny.Include(p => p.Produkty.Select(prod => prod.Produkt).Select(pr => pr.Kategoria)).SingleOrDefaultAsync(m => m.Id == IdMagazynu);
            List<ProduktDto> lista = new List<ProduktDto>();
            foreach (PozycjaMagazynu p in magazyn.Produkty)
            {
                if (filter(p))
                {
                    lista.Add(new ProduktDto
                    {
                        Nazwa = p.Produkt.Nazwa,
                        Opis = p.Produkt.Opis,
                        Cena = p.Cena,
                        Kategoria = p.Produkt.Kategoria?.Nazwa,
                        Ilosc = p.Ilosc
                    });
                }
            }
            return lista;
        }
        public void UsunProduktZMagazynu(int IdMagazynu, ProduktDto produkt)
        {
            var magazyn = _dataContext.Magazyny.Include(m => m.Produkty.Select(p => p.Produkt)).SingleOrDefault(m => m.Id == IdMagazynu);
            PozycjaMagazynu pro = magazyn.Produkty.SingleOrDefault(p => p.Produkt.Nazwa == produkt.Nazwa);
            //magazyn.Produkty.Remove(pro);
            _dataContext.Entry(pro).State = EntityState.Deleted;
        }
        public void DodajProdukt(int IdMagazynu, Produkt produkt, int ilosc, decimal cena)
        {
            var magazyn = _dataContext.Magazyny.Include(p => p.Produkty.Select(pr => pr.Produkt)).SingleOrDefault(m => m.Id == IdMagazynu);
            if (magazyn.Produkty.Any(p => p.Produkt.Nazwa == produkt.Nazwa))
            {
                var pro = magazyn.Produkty.SingleOrDefault(p => p.Produkt.Nazwa == produkt.Nazwa);
                pro.Ilosc += ilosc;
            }
            else
                magazyn.Produkty.Add(
                    new PozycjaMagazynu
                    {
                        Produkt = produkt,
                        Ilosc = ilosc,
                        Magazyn = magazyn,
                        Cena = cena
                    });
        }
        public async Task<bool> AktualizujProdukt(int IdMagazynu, ProduktDto produktDto, string staraNazwa)
        {
            var magazyn = _dataContext.Magazyny.Include(m => m.Produkty.Select(p => p.Produkt).Select(p => p.Kategoria)).SingleOrDefault(m => m.Id == IdMagazynu);
            var produkt = magazyn.Produkty.SingleOrDefault(p => p.Produkt.Nazwa == staraNazwa);
            if(produkt != null)
            {
                produkt.Produkt.Nazwa = produktDto.Nazwa;
                produkt.Produkt.Opis = produktDto.Opis;
                produkt.Produkt.Kategoria = await DajKategoriePoNazwie(produktDto.Kategoria);
                produkt.Ilosc = produktDto.Ilosc;
                produkt.Cena = produktDto.Cena;
                return true;
            }
            _dataContext.Entry(produkt).State = EntityState.Modified;
            await Task.Delay(10);
            return false;
        }

        //Użytkownik

        public async Task EdytujUzytkownika(Uzytkownik user)
        {
            var uzytkownik = await _dataContext.Użytkownicy.SingleOrDefaultAsync(u => u.Id == user.Id);
            uzytkownik.Imie = user.Imie;
            uzytkownik.Nazwa = user.Nazwa;
            uzytkownik.Nazwisko = user.Nazwisko;
            _dataContext.Entry(uzytkownik).State = EntityState.Modified;
        }

        public async Task ZmienHaslo(Uzytkownik user, string stareHaslo,string noweHaslo)
        {
            var uzytkownik = await _dataContext.Użytkownicy.SingleOrDefaultAsync(u => u.Id == user.Id);
            var hmac = new HMACSHA512(uzytkownik.HasloSalt);
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(stareHaslo));
            for(int i = 0; i < hash.Length; i++)
            {
                if (hash[i] != uzytkownik.HasloHash[i]) return;
            }
            var haslo = hmac.ComputeHash(Encoding.UTF8.GetBytes(noweHaslo));
            uzytkownik.HasloHash = haslo;
            _dataContext.Entry(uzytkownik).State = EntityState.Modified;
        }
        public bool DodajDoKoszyka(int IdMagazynu, Uzytkownik uzytkownik, ProduktDto produktDto)
        {
            var magazyn = _dataContext.Magazyny.Include(m => m.Produkty.Select(pr => pr.Produkt)).SingleOrDefault(m => m.Id == IdMagazynu);

            PozycjaMagazynu produkt = magazyn.Produkty.SingleOrDefault(p => p.Produkt.Nazwa == produktDto.Nazwa);
            var user = _dataContext.Użytkownicy.Where(u => u.Id == uzytkownik.Id).Include(k => k.Koszyk.Produkty.Select(prod => prod.Produkt)).SingleOrDefault();
            var sprawdzProdukt = user.Koszyk.Produkty.SingleOrDefault(p => p.Produkt.Nazwa == produktDto.Nazwa);
            if (sprawdzProdukt == null)
            {
                user.Koszyk.Produkty.Add(
                    new PozycjaKoszyka
                    {
                        Produkt = produkt.Produkt,
                        Ilosc = produktDto.Ilosc,
                        Cena = produkt.Cena,
                        Suma = produktDto.Ilosc * produkt.Cena
                    }
                );
               // produkt.Ilosc = produktDto.Ilosc;
                //uzytkownik.Koszyk.
                return true;
            }
            else if (sprawdzProdukt.Ilosc < produkt. Ilosc)
            {
                if (sprawdzProdukt.Ilosc + produktDto.Ilosc <= produkt.Ilosc)
                {
                    sprawdzProdukt.Ilosc += produktDto.Ilosc;
                    return true;
                }
                return false;
            }
            else return false;
        }

        public bool UsunZKoszyka(Uzytkownik uzytkownik, PozycjaKoszykaDto pozycja) 
        {
            var user = _dataContext.Użytkownicy.Include(u => u.Koszyk.Produkty.Select(pr => pr.Produkt)).SingleOrDefault(u => u.Id == uzytkownik.Id);
            PozycjaKoszyka doUsuniecia = user.Koszyk.Produkty.Where(p => p.Id == pozycja.PozycjaKoszykaId).SingleOrDefault();
            if(doUsuniecia != null)
            {
                //user.Koszyk.Produkty.Remove(doUsuniecia);
                _dataContext.Entry(doUsuniecia).State = EntityState.Deleted;
                return true;
            }
            return false;
        }
        public Uzytkownik Zaloguj(string nazwa, string haslo)
        {
            var user = _dataContext.Użytkownicy.Include(k => k.Koszyk.Produkty.Select(prod => prod.Produkt)).Include(z => z.Zamowienia.Select(p => p.Produkty.Select(pr => pr.Produkt))).SingleOrDefault(u => u.Nazwa == nazwa);
            if (user != null)
            {
                var hmac = new HMACSHA512(user.HasloSalt);
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(haslo));
                for (int i = 0; i < hash.Length; i++)
                {
                    if (hash[i] != user.HasloHash[i])
                        return null;
                }
            }
            return user;
        }
        public bool DodajUzytkownika(Uzytkownik uzytkownik)
        {
            var user = _dataContext.Użytkownicy.Include(p => p.Koszyk.Produkty.Select(prod => prod.Produkt)).SingleOrDefault(u => u.Nazwa == uzytkownik.Nazwa);
            if (user == null)
            {
                _dataContext.Użytkownicy.Add(uzytkownik);
                return true;
            }
            return false;
        }

        public void DoladujKonto(Uzytkownik user, decimal kwota)
        {
            var uzytkownik = _dataContext.Użytkownicy.Include(p => p.Koszyk.Produkty.Select(prod => prod.Produkt)).SingleOrDefault(u => u.Nazwa == user.Nazwa);
            uzytkownik.Pieniadze += kwota;
        }

        //Zapis
        public async Task<bool> ZapiszZmiany()
        {
           return await _dataContext.SaveChangesAsync() > 0;
        }
        public void Odswierz()
        {
            _dataContext = new BazaSklepKomputerowy();
        }
        public Uzytkownik WczytajUzytkownika(Uzytkownik user)
        {
            return _dataContext.Użytkownicy.Include(u => u.Koszyk.Produkty.Select(pro => pro.Produkt))
                .Include(u => u.Zamowienia.Select(p => p.Produkty.Select(pr=> pr.Produkt))).SingleOrDefault(u => u.Id == user.Id);
        }
    }
}
