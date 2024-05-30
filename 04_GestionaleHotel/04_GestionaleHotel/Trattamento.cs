using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_GestionaleHotel
{
    public class Trattamento
    {
        public string Tipo { get; set; }
        public double MoltiplicatoreCosto { get; set; }

        public override string ToString()
        {
            return this.Tipo;
        }
    }
}
