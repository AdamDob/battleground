using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuszajacyObiekt
{
    public partial class Form1 : Form
    {
        bool right, left;
        int x = 100;
        int y = 100;
        bool jump;
        int G = 30;
        int Force;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle((Brushes.Blue), x, y, 10, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(right == true ) {}
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
                x += 5;
            if (e.KeyData == Keys.Left)
                x -= 5;

            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (jump != true)
            {
                if(e.KeyCode == Keys.Escape)
                {
                    jump = true;
                    Force = G;
                }
            }
            Invalidate();
        }
    }
}
/*
 * if (e.KeyData == Keys.Up)
                y -= 5;
            if (e.KeyData == Keys.Down)

    */