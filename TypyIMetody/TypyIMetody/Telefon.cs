using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyIMetody
{
    public class Telefon
    {
        public string Marka { get; }
        public string Kolor { get; set; }
        public int Cale { get; }
        public RodzajTelefonu RodzajTelefonu { get; }
        private int WagaTelefonuBezObudowy { get; }
        public int Waga
        {
            get
            {
                if (Obudowa != null)
                    return Obudowa.Waga + WagaTelefonuBezObudowy;
                return WagaTelefonuBezObudowy;
            }
        }
        public string OpisStanu
        {
            get
            {
                switch (Stan)
                {

                    case StanTelefonu.Wylaczony:
                        return "Wylaczony";

                    case StanTelefonu.Polaczenie:
                        return "Polaczenie";
                        
                    case StanTelefonu.Wygaszony:
                        return "Wygaszony - Stan czuwania";
                        
                    case StanTelefonu.Hibernacja:
                        return "Stan Uspienia";

                    default:
                        throw new Exception("Nieobslugiwany stan");     
                }
            }
        }
        public StanTelefonu Stan { get; set; }
        public Obudowa Obudowa { get; }
        public string NumerDoKtoregoDzwonie { get; private set; }
        private readonly List<Kontakt> ListaKontaktow = new List<Kontakt>();

        /// <summary>
        /// Tworzy nowy obiekt klasy.
        /// </summary>
        /// <param name="marka">Okresla marke telefonu. Nie moze byc puste.</param>
        /// <param name="kolor"></param>
        /// <param name="cale">Okresla przekatna ekranu w calach. Musi byc wieksze od zera.</param>
        /// <param name="rodzajTelefonu"></param>
        /// <param name="wagaTelefonuBezObudowy"></param>
        /// <param name="obudowa"></param>
        public Telefon(string marka, string kolor, int cale,RodzajTelefonu rodzajTelefonu, 
            int wagaTelefonuBezObudowy, Obudowa obudowa)
        {
            if (obudowa == null)
                throw new ArgumentNullException(nameof(obudowa));
            if (string.IsNullOrWhiteSpace(marka))
                throw new ArgumentException(nameof(marka),"Marka nie moze byc pusta");
            if (string.IsNullOrWhiteSpace(kolor))
                throw new ArgumentException(nameof(kolor),"Kolor nie moze byc pusty");
            if (cale <= 0)
                throw new ArgumentException(nameof(cale));
            if (wagaTelefonuBezObudowy <= 0)
                throw new ArgumentException(nameof(wagaTelefonuBezObudowy));
            
            Obudowa = obudowa;
            Marka = marka;
            Kolor = kolor;
            Cale = cale;
            RodzajTelefonu = rodzajTelefonu;
            WagaTelefonuBezObudowy = wagaTelefonuBezObudowy;
            Stan = StanTelefonu.Wylaczony;
        
        }
        
        public void Zadzwon(string numer)
        {
            if (string.IsNullOrWhiteSpace(numer))
                throw new ArgumentException(nameof(numer));
            if (numer.Length < 9)
                throw new ArgumentException(nameof(numer),"Numer jest za krotki");
            
            Stan = StanTelefonu.Polaczenie;
            NumerDoKtoregoDzwonie = numer;
            
        }

        public void ZakonczPolanczenie()
        {
            NumerDoKtoregoDzwonie = null;
            Stan = StanTelefonu.Aktywny;

        }
        
        public void DodajKontakt(Kontakt kontakt)
        {
            ListaKontaktow.Add(kontakt);
        }

        public void UsunKontakt(Kontakt kontakt)
        {
            ListaKontaktow.Remove(kontakt);
        }

        public Kontakt[] ZwrocWszystkieKontakty()  
        {   
            //Nie zwracam listy bo ktos moze wyczyscic. Zwracam za to tablice.
            return ListaKontaktow.ToArray();
        }

        public override string ToString()
        {
            return "Marka: " + Marka + "\r\n Kolor: " + Kolor + "\r\n Cale: " + Cale + "\r\n Waga w gramach: "
                    + Waga + "\r\n Rodzaj Telefonu: " + RodzajTelefonu + "\r\n Stan Telefonu: " + OpisStanu;
        }


    }
    public enum StanTelefonu
    {
        Wylaczony,
        Polaczenie,
        Wygaszony,
        Hibernacja,
        Aktywny
    }
    public enum RodzajTelefonu
    {
       Brak,
       Komorkowy,
       Stacjonarny,
       Satelitarny
    }
}
