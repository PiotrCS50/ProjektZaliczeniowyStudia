using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    [Table("Magazyny")]
    public class Magazyn
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public bool Domyslny { get; set; }
        public List<PozycjaMagazynu> Produkty { get; set; }
    }
}
