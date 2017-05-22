using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonPowtorzenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Etui etui = new Etui("Czarny", 10, Material.Skorzany);
            Obudowa obudowa = new Obudowa(RodzajObudowy.Metalowy, "Szary", 0, etui);
            Kontakt kontakt1 = new Kontakt("Adam", "Dobrzycki", "508328445");
            Kontakt kontakt2 = new Kontakt("Milena", "Skorska", "512323247");

            Telefon telefon = new Telefon("Lg", "Brazowy", 30, 2.0, obudowa);
            telefon.Zadzwon("111222333");
            Console.WriteLine(telefon.NumerDoKtoregoDzwonie);
            telefon.Marka = "asd";
            Console.WriteLine(etui.Kolor);
            var etui2 = etui;
            etui2.Kolor = "bialy";
            Console.WriteLine(etui.Kolor);
            Console.ReadKey();
        }
    }
}
