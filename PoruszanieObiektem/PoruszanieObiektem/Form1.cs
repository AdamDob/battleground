using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoruszanieObiektem
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(Object sender, EventArgs e)
        {
            Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Right)
            {
                // gracz.PredkoscX += 5;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            int x = 0;
            int y = 0;
            int width = 200;
            int height = 100;
            Rectangle rect = new Rectangle(x, y, width, height);
            e.Graphics.FillRectangle((redBrush), x, y, 100, 100);
            
        }
    }
}
