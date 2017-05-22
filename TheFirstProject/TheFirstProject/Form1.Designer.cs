namespace TheFirstProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.All_books = new System.Windows.Forms.Button();
            this.Remove_book = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Book = new System.Windows.Forms.Button();
            this.Author_txb = new System.Windows.Forms.TextBox();
            this.Book_txb = new System.Windows.Forms.TextBox();
            this.Year_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_books_to_remove = new System.Windows.Forms.ListView();
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Book_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // All_books
            // 
            this.All_books.Location = new System.Drawing.Point(236, 260);
            this.All_books.Name = "All_books";
            this.All_books.Size = new System.Drawing.Size(75, 40);
            this.All_books.TabIndex = 0;
            this.All_books.Text = "Show All Books";
            this.All_books.UseVisualStyleBackColor = true;
            this.All_books.Click += new System.EventHandler(this.button1_Click);
            // 
            // Remove_book
            // 
            this.Remove_book.Location = new System.Drawing.Point(114, 260);
            this.Remove_book.Name = "Remove_book";
            this.Remove_book.Size = new System.Drawing.Size(75, 40);
            this.Remove_book.TabIndex = 0;
            this.Remove_book.Text = "Usun Ksiazke";
            this.Remove_book.UseVisualStyleBackColor = true;
            this.Remove_book.Click += new System.EventHandler(this.Remove_book_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Add_Book
            // 
            this.Add_Book.Location = new System.Drawing.Point(12, 260);
            this.Add_Book.Name = "Add_Book";
            this.Add_Book.Size = new System.Drawing.Size(75, 40);
            this.Add_Book.TabIndex = 0;
            this.Add_Book.Text = "Dodaj Ksiazke";
            this.Add_Book.UseVisualStyleBackColor = true;
            this.Add_Book.Click += new System.EventHandler(this.Add_Book_Click);
            // 
            // Author_txb
            // 
            this.Author_txb.Location = new System.Drawing.Point(12, 223);
            this.Author_txb.Name = "Author_txb";
            this.Author_txb.Size = new System.Drawing.Size(100, 20);
            this.Author_txb.TabIndex = 2;
            // 
            // Book_txb
            // 
            this.Book_txb.Location = new System.Drawing.Point(130, 223);
            this.Book_txb.Name = "Book_txb";
            this.Book_txb.Size = new System.Drawing.Size(100, 20);
            this.Book_txb.TabIndex = 3;
            // 
            // Year_txb
            // 
            this.Year_txb.Location = new System.Drawing.Point(236, 223);
            this.Year_txb.Name = "Year_txb";
            this.Year_txb.Size = new System.Drawing.Size(100, 20);
            this.Year_txb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // list_books_to_remove
            // 
            this.list_books_to_remove.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.list_books_to_remove.AllowColumnReorder = true;
            this.list_books_to_remove.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Author,
            this.Book_name,
            this.Year});
            this.list_books_to_remove.ForeColor = System.Drawing.SystemColors.Window;
            this.list_books_to_remove.FullRowSelect = true;
            this.list_books_to_remove.GridLines = true;
            this.list_books_to_remove.Location = new System.Drawing.Point(24, 45);
            this.list_books_to_remove.Name = "list_books_to_remove";
            this.list_books_to_remove.Size = new System.Drawing.Size(588, 149);
            this.list_books_to_remove.TabIndex = 0;
            this.list_books_to_remove.UseCompatibleStateImageBehavior = false;
            this.list_books_to_remove.View = System.Windows.Forms.View.Details;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 161;
            // 
            // Book_name
            // 
            this.Book_name.Text = "Book_name";
            this.Book_name.Width = 166;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 185;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 312);
            this.Controls.Add(this.list_books_to_remove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Year_txb);
            this.Controls.Add(this.Book_txb);
            this.Controls.Add(this.Author_txb);
            this.Controls.Add(this.Add_Book);
            this.Controls.Add(this.Remove_book);
            this.Controls.Add(this.All_books);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button All_books;
        private System.Windows.Forms.Button Remove_book;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Add_Book;
        private System.Windows.Forms.TextBox Author_txb;
        private System.Windows.Forms.TextBox Book_txb;
        private System.Windows.Forms.TextBox Year_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView list_books_to_remove;
        private System.Windows.Forms.ColumnHeader Book_name;
        private System.Windows.Forms.ColumnHeader Year;
        public System.Windows.Forms.ColumnHeader Author;
    }
}

