using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanychKolejnePodejscie
{
    class Program
    {
        static void Main(string[] args)
        {
            Kolpak kolpak = new Kolpak(15, "Czerwony");
            Felga felga = new Felga(30, RodzajFelgi.Aluminiowy, 15, kolpak);
            Opona opona = new Opona("Nowy", 30, 15, felga);
            Samochod autko = new Samochod(2015,"Porshe",1972);
            Console.WriteLine(autko.ToString());
            Console.ReadKey();
        }
    }
}
