using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach (string Wartosc in checkedListBox1.CheckedItems)
            {
                richTextBox1.Text += Wartosc + ", ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("ok");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usunieto nanana " + checkedListBox1.SelectedIndex);
            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
          
        }
    }
}
