using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy
{
    [Table("Kategorie")]
    public class Kategoria
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }

        public override string ToString()
        {
            return Nazwa;
        }
    }
}
