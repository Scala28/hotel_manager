using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_GestionaleHotel
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string? Telefono { get; set; }
        public string? email { get; set; }

        public override string ToString()
        {
            return this.ID.ToString() + " " + Nome + " " + Cognome;
        }
    }
}
