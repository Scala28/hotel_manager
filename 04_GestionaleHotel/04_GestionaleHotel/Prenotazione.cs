using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_GestionaleHotel
{
    public class Prenotazione
    {
        public int ID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int NumPersone { get; set; }
        public string IDTrattamento { get; set; }
        public Trattamento? trattamento { get; set; }
        public int IDCliente { get; set; }
        public Cliente? cliente { get; set; }
        public int IDCamera { get; set; }
        public Camera? camera { get; set; }
        public double Costo { get; set; }

    }
}
