using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanych
{
   public class Opona
    {
        public string Bieznik { get; private set; }
        public int Elastycznosc { get; private set; }
        public int Waga { get; private set; }

        public Opona(string bieznik, int elastycznosc, int waga)
        {
            Bieznik = bieznik;
            Elastycznosc = elastycznosc;
            Waga = waga;
        }
    }
}
