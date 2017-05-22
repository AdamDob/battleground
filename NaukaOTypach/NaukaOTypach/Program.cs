using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaukaOTypach
{
    class Program
    {
        static void Main(string[] args)
        {

            InnaKlasa klasa = new InnaKlasa();
            klasa.x = 4;

            int x = 5;
            Test test = new Test();
            test.Wartosc(x);
            test.Referencja(klasa);
            Console.WriteLine(x); // 5
            Console.WriteLine(klasa.x); // 2
        }
    }
}
