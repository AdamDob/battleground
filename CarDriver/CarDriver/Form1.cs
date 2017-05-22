using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// kolekcje
namespace CarDriver
{
    public partial class Form1 : Form
    {
        Kolko gracz = new Kolko();
        Kolko przeszkoda = new Kolko();
        Timer time = new Timer();
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.KeyDown += Form1_KeyDown;

            gracz.X = 50;
            gracz.Y = 70;
            gracz.Promien = 40;
            gracz.Kolor = Color.Black;
            gracz.PredkoscX = 0;
            gracz.PredkoscY = 0;

            przeszkoda.X = 650;
            przeszkoda.Y = 40;
            przeszkoda.Promien = 20;
            przeszkoda.Kolor = Color.Red;
            przeszkoda.PredkoscX = 10;
            przeszkoda.PredkoscY = -1;

            time.Tick += Time_Tick;
            time.Interval = 10;
            time.Start();

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            gracz.PrzeliczPolozenie(ClientRectangle);
            przeszkoda.PrzeliczPolozenie(ClientRectangle);
            var odcinek = Math.Sqrt(Math.Pow(przeszkoda.X - gracz.X, 2) + Math.Pow(przeszkoda.Y - gracz.Y, 2));
            if(odcinek <= gracz.Promien + przeszkoda.Promien)
            {
                time.Stop();
            }
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gracz.PredkoscY--;
                przeszkoda.PredkoscY--;
            }
            if (e.KeyCode == Keys.Down)
            {
                gracz.PredkoscY++;
            }
            if (e.KeyCode == Keys.Right)
            {
                gracz.PredkoscX++;
            }
            if (e.KeyCode == Keys.Left)
            {
                gracz.PredkoscX--;
            }
            Invalidate();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            //czyszczenie obiektu
            using (var brush = new SolidBrush(gracz.Kolor))
            {
                    e.Graphics.FillEllipse(brush, gracz.X - gracz.Promien, gracz.Y - gracz.Promien, gracz.Promien *2 , gracz.Promien *2);
                    
            }
            using (var brush = new SolidBrush(przeszkoda.Kolor))
            {
                e.Graphics.FillEllipse(brush, przeszkoda.X - przeszkoda.Promien, przeszkoda.Y - przeszkoda.Promien,
                    przeszkoda.Promien * 2, przeszkoda.Promien * 2);
            }
            

        }

    }
}
