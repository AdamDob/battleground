using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyDanychKolejnePodejscie
{
    class Samochod
    {
        public int Przebieg;
        public string Marka;
        public float RokProdukcji;

        public Samochod(int przebieg, string marka, int rokProdukcji)
        {
            Marka = marka;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg;
        }

        public override string ToString()
        {
            return $" Przebieg = {Przebieg} \r\n Marka: {Marka} \r\n RokProdukcji: {RokProdukcji}";
        }
    }
}
