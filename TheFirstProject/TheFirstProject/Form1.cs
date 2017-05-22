using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TheFirstProject
{
    public partial class Form1 : Form
    {

        string sciezka = @"C:\Users\ADAS\Desktop\Ksiazki.txt";


        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My frist seriously project", "LET'S GO!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\ADAS\Desktop\Ksiazki.txt");
            MessageBox.Show(text);
        }

        private void Add_Book_Click(object sender, EventArgs e)
        {
            ListViewItem items = new ListViewItem(Author_txb.Text);
            items.SubItems.Add(Book_txb.Text);
            items.SubItems.Add(Year_txb.Text);

            list_books_to_remove.Items.Add(items);
            Author_txb.Text = "";
            Book_txb.Text = "";
            Year_txb.Text = "";

            File.WriteAllText(sciezka, list_books_to_remove);
            
            
                // Author_txb->Text = 
          //  string[] lines = { "First line", "Second line", "Third line" };
          //  System.IO.File.WriteAllLines(@"C:\Users\ADAS\Desktop\Ksiazki.txt", lines);

        }

        private void Remove_book_Click(object sender, EventArgs e)
        {
            list_books_to_remove.SelectedItems[0].Remove();
        }
    }
}
