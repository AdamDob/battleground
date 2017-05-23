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
        public int KolejnaPrzeszkzoda;
        private int predkoscX;
        private int predkoscY;
        public int PredkoscX
        {
            get { return predkoscX; }
            set
            {
                
                if (value > 5)
                    predkoscX = 5;
                else
                    if (value < -5)
                    predkoscX = -5;
                else
                    predkoscX = value;
            }
        }
        public int PredkoscY
        {
            get { return predkoscY; }
            set
            {
                if (value > 5)
                    predkoscY = 5;
                else
                    if (value < -5)
                    predkoscY = -5;
                else
                    predkoscY = value;
            }
        }

        public Kolko(Rectangle obszarRoboczy)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            predkoscX = rnd.Next(-5, 5);
            predkoscY = rnd.Next(-5, 5);
            X = rnd.Next(1, obszarRoboczy.Width);
            Y = rnd.Next(1, obszarRoboczy.Height);
            Promien = rnd.Next(10, 30);
            int red = rnd.Next(1, 255);
            int green = rnd.Next(1, 255);
            int blue = rnd.Next(1, 255);
            Kolor = Color.FromArgb(red, green, blue);
        }

        public bool WykryjKolizje(Kolko kolko)
        {
            var odcinek = Math.Sqrt(Math.Pow(kolko.X - X, 2)
                    + Math.Pow(kolko.Y - Y, 2));

            if (odcinek <= Promien + kolko.Promien)
            {
                Random rnd = new Random();
                int red = rnd.Next(1, 255);
                int green = rnd.Next(1, 255);
                int blue = rnd.Next(1, 255);
                Kolor = Color.FromArgb(red, green, blue);
                return true;
            }
            return false;
        }

        public void PrzeliczPolozenie(Rectangle obszarRoboczy)
        {
            X += PredkoscX;
            Y += PredkoscY;



            if (X + Promien >= obszarRoboczy.Width)
            {
                X = obszarRoboczy.Width - Promien;
                PredkoscX = PredkoscX * -1;
                Kolor = Color.FromArgb(50, 50, 50);

            }
            if (Y + Promien >= obszarRoboczy.Height)
            {
                Y = obszarRoboczy.Height - Promien;
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

        public void Narysuj(Graphics g)
        {
            var brush = new SolidBrush(Kolor);

            g.FillEllipse(brush, X - Promien, Y - Promien, Promien * 2, Promien * 2);
            brush.Dispose();
        }
    }
}
