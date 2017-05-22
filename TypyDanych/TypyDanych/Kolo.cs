using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanych
{
    public class Kolo
    {
        public int Srednica
        {
            get
            {
                return Felga.Srednica;
            }
        }
        public int Waga
        {
            get
            {
                return Felga.Waga + Opona.Waga;
            }
        }
        public Felga Felga { get; set; }
        public Opona Opona { get; set; }
    }
}
