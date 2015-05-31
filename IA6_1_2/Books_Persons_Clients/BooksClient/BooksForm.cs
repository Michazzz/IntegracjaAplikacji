using System;
using BooksClient.BooksService;
using System.Windows.Forms;

namespace BooksClient
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void Szukaj_Click(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem;
            var bm = new BookManagerClient();
            var searchKey = textBox1.Text;

            book[] books = new book[] {};

            if (item.Equals("Tytuł"))
            {
                books = bm.searchByTitle(searchKey);
            } else if (item.Equals("Wydawnictwo"))
            {
                books = bm.searchByPublisher(searchKey);
            } else if (item.Equals("ISBN"))
            {
                var book = bm.searchByISBN(searchKey);
                books = new book[] {book};
            }
            
            dataGridView1.DataSource = books;
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            new AddBook().ShowDialog();
        }
    }
}
