using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonsClient.PersonService;

namespace PersonsClient
{
    static class Program
    {

        public static string Token = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var bm = new PersonManagerClient();

            Token = bm.loginRequest("testuser", "P@ssw0rd");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PersonsForm());
        }
    }
}
