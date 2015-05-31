using System;
using PersonsClient.PersonService;
using System.Windows.Forms;

namespace PersonsClient
{
    public partial class PersonsForm : Form
    {
        public PersonsForm()
        {
            InitializeComponent();
        }

        private void Szukaj_Click(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem;
            var bm = new PersonManagerClient();
            var searchKey = textBox1.Text;

            person[] persons = new person[]{};

            if (item.Equals("Imię"))
            {
                persons = bm.searchByName(searchKey, Program.Token);
            } else if (item.Equals("Nazwisko"))
            {
                persons = bm.searchByLastname(searchKey, Program.Token);
            } else if (item.Equals("Pesel"))
            {
                var book = bm.searchByPesel(searchKey, Program.Token);
                persons = new person[] { book };
            }
            
            dataGridView1.DataSource = persons;
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            var bm = new PersonManagerClient();
            bm.logout(Program.Token);
        }
    }
}
