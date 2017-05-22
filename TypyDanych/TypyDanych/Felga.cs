using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanych
{
   public class Felga
    {
        public RodzajFelgi Rodzaj { get; }
        public int Waga { get; }
        public int Srednica { get; }

        public Felga(int waga, RodzajFelgi rodzajFelgi, int srednica)
        {
            Rodzaj = rodzajFelgi;
            Waga = waga;
            Srednica = srednica;
        }
    }
    public enum RodzajFelgi
    {
        brak = 0,
        Alufelga = 1,
        Stalowa = 2
    }
}
