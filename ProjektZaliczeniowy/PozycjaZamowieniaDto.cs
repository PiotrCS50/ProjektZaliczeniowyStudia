using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    public class PozycjaZamowieniaDto
    {
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public decimal Cena { get; set; }
        public decimal Suma { get; set; }
    }
}
