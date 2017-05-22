using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var auto = new Samochod("Gold", 9192, "Niebieski");
            Console.WriteLine(auto.WypiszStringa());

            Console.ReadKey();
        }
    }
}
