using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    public class PozycjaKoszykaDto
    {
        public int PozycjaKoszykaId { get; set; }
        public string NazwaProduktu { get; set; }
        public int Ilosc { get; set; }
        public decimal Cena { get; set; }
        public decimal Suma { get; set; }
    }
}
