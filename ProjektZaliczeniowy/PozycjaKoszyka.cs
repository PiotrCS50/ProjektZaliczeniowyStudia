using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    [Table("PozycjeKoszyka")]
    public class PozycjaKoszyka
    {
        public int Id { get; set; }
        public Produkt Produkt { get; set; }
        public int Ilosc { get; set; }
        public  decimal Cena { get; set; }
        public decimal Suma { get; set; }
    }
}
