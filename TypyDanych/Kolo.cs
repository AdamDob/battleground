using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanych
{
    public class Kolo
    {
        public int Srednica { get; private set; }
        public Opona Opona { get; private set; }
        public int Waga { get; private set; }

        public Kolo(int srednica, Opona opona, int waga)
        {
            Srednica = srednica;
            Opona = opona;
            Waga = waga;
        }
    }
}
