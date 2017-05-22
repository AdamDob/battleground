using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonPowtorzenie
{
   public class Etui
    {
        public string Kolor;
        public int Waga;
        public Material Material; 

        public Etui(string kolor, int waga, Material material)
        {
            Kolor = kolor;
            Waga = waga;
            Material = material;
        }
    }
    public enum Material
    {
        Skorzany,
        Plastikowy,
        Metalopodony
    }
}
