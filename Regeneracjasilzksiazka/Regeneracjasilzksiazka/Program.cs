using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regeneracjasilzksiazka
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] srednia = { 19, 34, 23, 54, 31 };            int suma = 0;
            double ssrednia;
            Console.WriteLine("wieksz uczenikow ");
            for(int i = 0; i< srednia.Length; i++)
            {
                Console.WriteLine("{0}, ", srednia[i]);
                suma += srednia[i];
            }
            ssrednia = (double)suma / srednia.Length;
            Console.WriteLine();
            Console.WriteLine("srednia: {0}", ssrednia);
            Console.ReadKey();
        }
    }
}
