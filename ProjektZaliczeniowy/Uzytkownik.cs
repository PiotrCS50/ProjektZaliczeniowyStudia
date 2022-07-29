using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    [Table("Uzytkownicy")]
    public class Uzytkownik
    {
        public int Id { get; set; }
        [Required]
        public string Nazwa { get; set; }
        [Required]
        public string Imie { get; set; }
        [Required]
        public string Nazwisko { get; set; }
        [Required]
        public byte[] HasloHash { get; set; }
        [Required]
        public byte[] HasloSalt { get; set; }
        [Required]
        public string TypKonta { get; set; }
        [Required]
        public decimal Pieniadze { get; set; }
        public Koszyk Koszyk { get; set; }
        public List<Zamowienie> Zamowienia { get; set; }
    }
}
