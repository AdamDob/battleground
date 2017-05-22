using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanychKolejnePodejscie
{
    public class Kolpak
    {
        public int Srednica { get; private set; }
        public string Kolor { get; set; }

        public Kolpak(int srednica, string kolor)
        {
           
            Srednica = srednica;
            Kolor = kolor;
        }
    }
}
