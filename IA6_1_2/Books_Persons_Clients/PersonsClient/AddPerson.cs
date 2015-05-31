using System;
using System.Windows.Forms;
using PersonsClient.PersonService;

namespace PersonsClient
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person book = new person();
            book.name = tbName.Text;
            book.lastname = tbLastname.Text;
            book.sex = tbSex.Text;
            book.birthday = tbBirthday.Text;
            book.age = int.Parse(tbAge.Text);
            book.ageSpecified = true;
            book.pesel = tbPesel.Text;

            var authors = tbEducations.Text.Split(',');
            book.education = authors;

            var bm = new PersonManagerClient();
            //bm.(ref book);
            Close();
        }
    }
}
