using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveObject
{
    public partial class Form1 : Form
    {
        Kolo gracz = new Kolo();
        Kolo przeszkodka = new Kolo();
        Timer time = new Timer();


        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.KeyDown += Form1_KeyDown;

            gracz.X = 20;
            gracz.Y = 40;
            gracz.Promien = 40;
            gracz.Kolor = Color.Red;
            gracz.PredkoscX = 0;
            gracz.PredkoscY = 0;

            przeszkodka.X = 650;
            przeszkodka.Y = 40;
            przeszkodka.Promien = 20;
            przeszkodka.Kolor = Color.Red;
            przeszkodka.PredkoscX = 10;
            przeszkodka.PredkoscY = -1;

            // time.Tick += Time_Tick;
            time.Interval = 1000;
            time.Start();
        }
        private void Time_Tick(object sender, EventArgs e)
        {
            gracz.PrzeliczPolozenie(ClientRectangle);
            przeszkodka.PrzeliczPolozenie(ClientRectangle);
            var odcinek = Math.Sqrt(Math.Pow(przeszkodka.X - gracz.X, 2) + Math.Pow(przeszkodka.Y - gracz.Y, 2));
            if (odcinek <= gracz.Promien + przeszkodka.Promien)
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
                przeszkodka.PredkoscY = 10;
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
                e.Graphics.FillEllipse(brush, gracz.X - gracz.Promien, gracz.Y - gracz.Promien, gracz.Promien * 2, gracz.Promien * 2);

            }
            using (var brush = new SolidBrush(przeszkodka.Kolor))
            {
                e.Graphics.FillEllipse(brush, przeszkodka.X - przeszkodka.Promien, przeszkodka.Y - przeszkodka.Promien,
                    przeszkodka.Promien * 2, przeszkodka.Promien * 2);
            }



        }
    }
}
