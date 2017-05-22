using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanychKolejnePodejscie
{
   public class Opona
    {
        public int WagaOpony;
        public int SrednicaOpony;
        public string Bieznik;
        public Felga Felga { get; set; }
        public int Waga
        {
            get
            {
                if (Felga != null)
                    return Felga.Waga + WagaOpony;
                return WagaOpony;
            }
        }
        public int Srednica
        {
            get
            {
                if (Felga != null)
                    return Felga.Srednica + SrednicaOpony;
                return SrednicaOpony;
            }
        }
        public Opona(string bieznik,int waga, int srednica,Felga felga)
        {
            Bieznik = bieznik;
            WagaOpony = waga;
            SrednicaOpony = srednica;
            Felga = felga;
        }
    }
}
