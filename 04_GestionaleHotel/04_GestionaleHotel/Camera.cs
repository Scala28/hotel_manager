using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_GestionaleHotel
{
    public class Camera
    {
        public int ID { get; set; }
        public int Posti { get; set; }
        public string? Foto { get; set; }
        public List<double> Voti { get; set; }
        public double Costo { get; set; }

        public override string ToString()
        {
            return this.ID.ToString();
        }
    }
}
