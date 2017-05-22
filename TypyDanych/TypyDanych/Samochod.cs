using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanych
{
   public class Samochod
    {
        // Nasze zmienne klasy
        public string Marka { get; }      
        public int Vin { get; }
        public string Kolor { get; set; }
        // Konstruktor 
        public Samochod(string marka, int vin, string kolor)
        {
            Marka = marka;
            Vin = vin;
            Kolor = Kolor;
        }
        //metoda ktora wypisuje 
        public string WypiszStringa()
        {
            if (Kolor == "czerwony")
            
            return "Marka: " + Marka + "\r\n Vin: " + Vin;
            return "Marka: " + Marka + "\r\n Vin: " + Vin + "\r\n Kolor: " + Kolor;
        }

    }
}
