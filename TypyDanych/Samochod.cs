using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanych
{
    public class Samochod
    {
        public string Marka { get; private set; }
        public int Vin { get; private set ; }
        public string Kolor { get; set; }
        public int Waga { get; private set; }
        public Kolo KoloPrzednieLewe { get; private set; }
        public Kolo KoloPrzedniePrawe { get; private set; }
        public Kolo KoloTylnieLewe { get; private set; }
        public Kolo KoloTylniePrawe { get; private set; }

        public Samochod(string marka, int vin, string kolor)
        {
            Marka = marka;
            Kolor = kolor;
            Vin = vin;

            PrzeliczWage();
        }

        public string PodajStringa()
        {
            if (Kolor.ToLower() == "czerwony")
                return "Marka: " + Marka + "\r\n Vin: " + Vin + "\r\n Waga: " + Waga;
            return "Marka: " + Marka + "\r\n Vin: " + Vin + "\r\n Kolor: " + Kolor + "\r\n Waga: " + Waga; ;
        }

        

        public void ZalozKola(Kolo koloPrzednieLewe, Kolo koloPrzedniePrawe, Kolo koloTylnieLewe, Kolo koloTylniePrawe)
        {
            KoloPrzednieLewe = koloPrzednieLewe;
            KoloPrzedniePrawe = koloPrzedniePrawe;
            KoloTylnieLewe = KoloTylnieLewe;
            KoloTylniePrawe = KoloTylniePrawe;

            PrzeliczWage();
        }

        private void PrzeliczWage()
        {
            Waga = 0;

            if (KoloPrzednieLewe != null)
                Waga += KoloPrzednieLewe.Waga;

            if (KoloPrzedniePrawe != null)
                Waga += KoloPrzedniePrawe.Waga;

            if (KoloTylnieLewe != null)
                Waga += KoloTylnieLewe.Waga;

            if (KoloTylniePrawe != null)
                Waga += KoloTylniePrawe.Waga;
        }
    }
    
}
