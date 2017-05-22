using System;*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyIMetody
{
    class Program
    {
        static void Main(string[] args)
        {
            var etui = new Etui("Czerwony", Material.Skorzany, 10);
            var obudowa = new Obudowa("Sszary", RodzajObudowy.Plastikowa,50,etui);
            var telefon = new Telefon("Lg", "Szary",5,RodzajTelefonu.Komorkowy,500,obudowa);
            var kontakt = new Kontakt("Adam", "Dobrzycki", "508328445");
            var kontakt1 = new Kontakt("Adrian", "Bryk", "506507987");
            telefon.Stan = StanTelefonu.Hibernacja;
            telefon.Zadzwon("508328445");
            Console.WriteLine(telefon.NumerDoKtoregoDzwonie);
            Console.WriteLine(telefon.Stan);
            telefon.ZakonczPolanczenie();
            Console.WriteLine(telefon.NumerDoKtoregoDzwonie);
            Console.WriteLine(telefon.Stan);
            telefon.DodajKontakt(kontakt);
            telefon.DodajKontakt(kontakt1);
            var kontakty = telefon.ZwrocWszystkieKontakty();
            var edytowany =  kontakty[0];
            edytowany.Imie = "Jacek";
            Console.WriteLine(kontakt.ToString());
            

            Console.ReadKey();


        }
    }
}
