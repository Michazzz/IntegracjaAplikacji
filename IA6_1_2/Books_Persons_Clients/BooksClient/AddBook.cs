using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksClient.BooksService;

namespace BooksClient
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            book book = new book();
            book.title = tbTitle.Text;
            book.isbn = tbIsbn.Text;
            book.pages = int.Parse(tbPages.Text);
            book.year = int.Parse(tbYear.Text);
            book.pagesSpecified = true;
            book.yearSpecified = true;
            book.publisher = tbPublisher.Text;

            var authors = tbAuthors.Text.Split(',');
            book.authors = authors;

            var bm = new BookManagerClient();
            bm.addBook(ref book);
            Close();
        }
    }
}
