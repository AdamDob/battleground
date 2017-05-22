using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonPowtorzenie
{
   public class Telefon
    {
        public string Marka;
        public string Kolor;
        private int WagaTelefonuBezObudowy;
        public Obudowa Obudowa { get; }
        public int Waga
        {
            get
            {
                if (Obudowa != null)
                    return Obudowa.Waga + WagaTelefonuBezObudowy;
                return WagaTelefonuBezObudowy;
            }
        }
        public double Cale;
        public StanTelefonu Stan;
        public string OpisStanu
        {
            get
            {
                switch(Stan)
                {
                    case StanTelefonu.Aktywny:
                        return "Gotowy do uzycia - Aktywny";
                    case StanTelefonu.Hibernacja:
                        return "Uspiony";
                    case StanTelefonu.Poleczenie:
                        return "Polaczenie";
                    case StanTelefonu.Wygaszony:
                        return "Wygaszony";
                    case StanTelefonu.Wylaczony:
                        return "Wylaczony";
                    default:
                        throw new Exception("Nieobslugiwany stan");
                }
            }
        }
        public string NumerDoKtoregoDzwonie;
        public readonly List<Kontakt> ListaKontaktow = new List<Kontakt>();

        public Telefon(string marka, string kolor, int waga, double cale,Obudowa obudowa)
        {
            Marka = marka;
            Kolor = kolor;
            WagaTelefonuBezObudowy = waga;
            Cale = cale;
            Obudowa = obudowa;
        }
        
        public void Zadzwon(string numer)
        {
            Stan = StanTelefonu.Poleczenie;
            NumerDoKtoregoDzwonie = numer;
        }
        public void ZakonczPolaczenie()
        {
            NumerDoKtoregoDzwonie = null;
            Stan = StanTelefonu.Aktywny;

        }
        public void DodajKontakt(Kontakt Kontakt)
        {
            ListaKontaktow.Add(Kontakt);
        }
        public void UsunKontakt(Kontakt Kontakt)
        {
            ListaKontaktow.Remove(Kontakt);
        }
        public Kontakt[] ZwrocWszystkieKontakty()
        {
            return ListaKontaktow.ToArray();
        }
        public override string ToString()
        {
            return $" Marka: {Marka} \r\n Kolor {Kolor} \r\n Waga {Waga} \r\n Cale {Cale}";
        }
    }
    public enum StanTelefonu
    {
        Wylaczony,
        Poleczenie,
        Aktywny,
        Hibernacja,
        Wygaszony
    }
}
