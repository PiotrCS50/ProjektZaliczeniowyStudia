using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    [Table("Produkty")]
    public class Produkt
    {
        public int Id { get; set; }
        [Required]
        public string Nazwa { get; set; }
        [Required]
        public Kategoria Kategoria { get; set; }
        [Required]
        public string Opis { get; set; }
    }
}
