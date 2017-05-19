using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanych
{
    class Dziupla
    {
        
        public string Adres { get; private set; }
        public Dziupla(string adres)
        {
            Adres = adres;
        }
        public void ZmienKolor(Samochod samochod,string nowyKolor)
        {
            samochod.Kolor = nowyKolor;
        }
    }
}
