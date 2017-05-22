using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Form1 
        public Form1()
        {
            InitializeComponent();
        }

        private void Okey_CheckedChanged(object sender, EventArgs e)
        {
            if(Okey.Checked)
            {
                this.BackColor = Color.Aqua;
                Okey.Text = "Anuluj";
            }
            else
            {
                this.BackColor = Color.ForestGreen;
                Okey.Text = "ok";
            }
        }

        
    }
}
