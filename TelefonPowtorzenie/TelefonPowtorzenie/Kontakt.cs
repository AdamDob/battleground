using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonPowtorzenie
{
    public class Kontakt
    {
        private string _imie;
        private string _nazwisko;
        private string _numer;

        public string Imie
        {
            get { return _imie; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(nameof(Imie));
                _imie = value;
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
            return $" Imie : {Imie} \r\n Nazwisko: {Nazwisko} \r\n Numer: {Numer}";
        }
    }
}
