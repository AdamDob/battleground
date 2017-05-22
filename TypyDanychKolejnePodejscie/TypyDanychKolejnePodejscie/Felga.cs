using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanychKolejnePodejscie
{
    public class Felga
    {
        public int Waga;
        public RodzajFelgi RodzajFelgi;
        public Kolpak Kolpak {get; set;}
        private int SrednicaFelgi;
        public int Srednica
        {
            get
            {
                if (Kolpak != null)
                {
                     return Kolpak.Srednica + SrednicaFelgi;
                }

                return SrednicaFelgi;
            }
        }
        public Felga(int waga, RodzajFelgi rodzajFeligi, int srednicaFelgi,Kolpak kolpak)
        {
            Waga = waga;
            RodzajFelgi = rodzajFeligi;
            SrednicaFelgi = srednicaFelgi;
            Kolpak = kolpak;
        }
    }
    public enum RodzajFelgi
    {
        Aluminiowy,
        Stalowy
    }
}
