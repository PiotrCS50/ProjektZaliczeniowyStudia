using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    public class ProduktDto
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public string Kategoria { get; set; }
        public decimal Cena { get; set; }
        public int Ilosc { get; set; }
    }
}
