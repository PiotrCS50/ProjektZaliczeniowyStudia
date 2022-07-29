using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    [Table("Zamowienia")]
    public class Zamowienie
    {
        public int Id { get; set; }
        public List<PozycjaZamowienia> Produkty { get; set; }
        public Uzytkownik Uzytkownik { get; set; }
    }
}
