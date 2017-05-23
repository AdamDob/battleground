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
        Kolko gracz;
        Timer time = new Timer();
        List<Kolko> Przeszkody = new List<Kolko>();
       
 
        public Form1()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            DoubleBuffered = true;
            KeyDown += Form1_KeyDown;
            time.Tick += Time_Tick;
            time.Interval = 1;
            time.Start();
            
        }
        
        private void Time_Tick(object sender, EventArgs e)
        {
            gracz.PrzeliczPolozenie(ClientRectangle);

            foreach (var kolejnaPrzeszkoda in Przeszkody.ToArray())
            {
                kolejnaPrzeszkoda.PrzeliczPolozenie(ClientRectangle);
                bool czyKolizja = gracz.WykryjKolizje(kolejnaPrzeszkoda);
                if (czyKolizja)
                {
                    Przeszkody.Remove(kolejnaPrzeszkoda);
                }
                //if(gracz.WykryjKolizje(kolejnaPrzeszkoda))
                //{
                //    Przeszkody.Remove(kolejnaPrzeszkoda);
                //}
                    
            }
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gracz.PredkoscY -= 2;
            }
            if (e.KeyCode == Keys.Down)
            {
                gracz.PredkoscY += 2;
            }
            if (e.KeyCode == Keys.Right)
            {
                gracz.PredkoscX += 2;
            }
            if (e.KeyCode == Keys.Left)
            {
                gracz.PredkoscX -= 2;
            }
            if (e.KeyCode == Keys.Space)
            {
               //1. sprawdz ile jest jablek
               //2. podziel na dwie czesci
               //3. usun jedna z czesci
               ///----///
               // jedno wyrzucam drugie zostawiam 
               for(int i = 0; i < Przeszkody.Count; i++)
                {
                    if(i %2==0 )
                    {
                        Przeszkody.RemoveAt(i);
                    }
                }
            }

            if(e.KeyCode == Keys.A)
            {
                for (int i = 0; i < 20; i++)
                {
                    Przeszkody.Add(new Kolko(ClientRectangle));
                }
            }
           
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            gracz.Narysuj(e.Graphics);
            foreach(var obj in Przeszkody)
            {
                obj.Narysuj(e.Graphics);
            }
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            gracz = new Kolko(ClientRectangle);

            gracz.X = 50;
            gracz.Y = 70;
            gracz.Promien = 40;
            gracz.Kolor = Color.Black;
            gracz.PredkoscX = 100;
            gracz.PredkoscY = 0;

            for(int i = 0; i < 200; i++)
            {
                Przeszkody.Add(new Kolko(ClientRectangle));
            }
        }
    }
}
/*
 Wyswietlanie wyniku
 ilosc zyc
 zmienic gracza
 pasek z nowa gra
 pasek zycia

  */