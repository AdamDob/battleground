using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriver
{
    public class Kolko
    {
        public int Promien;
        public Color Kolor;
        public int X;
        public int Y;
        private int predkoscX;
        private int predkoscY;
        public int PredkoscX
        {
            get { return predkoscX; }
            set
            {
                if(value < 5 && value > -5)
                predkoscX = value;
            }
        }
        public int PredkoscY
        {
            get { return predkoscY; }
            set
            {
                if(value < 5 && value > -5)
                predkoscY = value;
            }
        }

        public void PrzeliczPolozenie(Rectangle r)
        {
            X += PredkoscX;
            Y += PredkoscY;



            if (X + Promien >= r.Width)
            {
                X = r.Width - Promien;
                PredkoscX = PredkoscX * -1;

            }
            if (Y + Promien >= r.Height)
            {
                Y = r.Height - Promien;
                PredkoscY = PredkoscY * -1;
            }
            if (X - Promien <= 0)
            {
                X = Promien;
                PredkoscX = PredkoscX * -1;
            }
            if (Y - Promien <= 0)
            {
                Y = Promien;
                PredkoscY = PredkoscY * -1;
            }
        }
    }
}
