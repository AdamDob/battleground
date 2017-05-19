using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            var samochod = new Samochod("Volvo", 123, "Niebieski");
            var dziupla = new Dziupla("Kilinskiego");

        //  Console.WriteLine(samochod.PodajStringa());
         //  Console.WriteLine(samochod.ObnizWage(5));
           // while (samochod.ObnizWage(7) > 0)
           
            var samochod1 = new Samochod("Fiat" , 142, "Rozowy");
            var samochod2 = new Samochod("Fiat" , 9992, "Fioletowy");
            var samochod3 = new Samochod("Peugot" , 14442, "Pomaranczowy");
            dziupla.ZmienKolor(samochod2,"Niebieski");
            Console.WriteLine(dziupla.Adres);
            Console.WriteLine(samochod2.PodajStringa());
           // Console.WriteLine(samochod.PodajStringa());
            // Console.WriteLine(samochod.Marka);

            //Console.WriteLine(samochod.ZwrocMarke());
            //samochod.ZmienMarke("Fiat");
            //Console.WriteLine(samochod.ZwrocMarke());

            Console.ReadKey();
        }
    }

}
