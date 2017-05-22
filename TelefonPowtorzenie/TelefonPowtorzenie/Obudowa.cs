using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonPowtorzenie
{
   public class Obudowa
    {
        public RodzajObudowy RodzajObudowy;
        public string Kolor;
        private int WagaObudowy;
        public Etui Etui { get; set; }
        public int Waga
        {
            get
            {
                if (Etui != null)
                    return Etui.Waga + WagaObudowy;
                return WagaObudowy;
            }
        }
        public Obudowa(RodzajObudowy rodzajObudowy, string kolor, int waga, Etui etui)
        {
            RodzajObudowy = rodzajObudowy;
            Kolor = kolor;
            WagaObudowy = waga;
            Etui = etui;
        }
    }

    public enum RodzajObudowy
    {
        Brak,
        Aluminiowy,
        Plastikowy,
        Metalowy
    }
}
