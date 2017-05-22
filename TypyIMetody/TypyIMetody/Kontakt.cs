using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyIMetody
{
   public class Kontakt
    {
        private string _imie;   //w prywatnych nazwach z podkresleniem na poczatku
        private string _nazwisko;
        private string _numer;

        public string Imie
        {
            get { return _imie; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(nameof(Imie));
                _imie = value;                // wlasciwosc
            }
        }
        public string Nazwisko
        {
            get { return _nazwisko; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(nameof(Nazwisko));
                _nazwisko = value;
            }
        }

        public string Numer
        {
            get { return _numer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(nameof(Numer));
                _numer = value;
            }
        }

        public Kontakt(string imie, string nazwisko, string numer)
        {
            
            Imie = imie;
            Nazwisko = nazwisko;
            Numer = numer;
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko} - {Numer}"; 
        }
    }
}
