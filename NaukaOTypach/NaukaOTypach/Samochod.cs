using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaOTypach
{
    class Test
    {
        public void Wartosc(int x)
        {
            x = x * 2;
        }
        public void Referencja(InnaKlasa innaKlasa)
        {
            innaKlasa.x = 2;
        }
    }
}
