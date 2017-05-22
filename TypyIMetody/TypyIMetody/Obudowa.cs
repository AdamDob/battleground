using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyIMetody
{
    public class Obudowa
    {
        
        public string Kolor { get; private set; }
        public RodzajObudowy RodzajObudowy { get; private set; }
        private int wagaObudowy;
        public int Waga
        {
            get
            {
                if (Etui != null)
                    return Etui.Waga + wagaObudowy;
                return wagaObudowy;
            }
        }
        public Etui Etui { get; set; }
        public Obudowa(string kolor, RodzajObudowy rodzajObudowy, int waga)
        {
            if (waga <= 0)
                throw new ArgumentException(nameof(waga));
            if (string.IsNullOrWhiteSpace(kolor))
                throw new ArgumentException(nameof(kolor));

            wagaObudowy = waga;
            Kolor = kolor;
            RodzajObudowy = rodzajObudowy;
        }
        public Obudowa(string kolor, RodzajObudowy rodzajObudowy, int waga,Etui etui)
        {
            Etui = etui;
            wagaObudowy = waga;
            Kolor = kolor;
            RodzajObudowy = rodzajObudowy;
        }
    }

    public enum RodzajObudowy
    {
        Brak,
        Plastikowa,
        Metalowa

    }
}
