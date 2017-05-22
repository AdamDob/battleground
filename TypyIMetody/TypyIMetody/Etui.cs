using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyIMetody
{
   public class Etui
    {
        public string Kolor { get; set; }
        public Material Material { get; private set; }
        public int Waga { get; private set; }

        public Etui(string kolor, Material material, int waga )
        {
            if (string.IsNullOrWhiteSpace(kolor))          //walidacja 
                throw new ArgumentNullException(nameof(kolor));
            if (waga <= 0)
                throw new ArgumentException(nameof(waga));
            Kolor = kolor;
            Material = Material;
            Waga = waga;
        }

    }
    public enum Material
    {
        Skorzany,
        Plastikowy,
        MetaloPodobny
    }
}
