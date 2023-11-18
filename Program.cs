using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969PA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string title = "ALTER TABLE appointment ALTER title SET DEFAULT 'unnecessary'";
            string descrip = "ALTER TABLE appointment Change Column description description VARCHAR(250) NULL";
            string location = "ALTER TABLE appointment Change Column location location VARCHAR(250) NULL";
            string contact = "ALTER TABLE appointment Change Column contact contact VARCHAR(250) NULL";
            string url = "ALTER TABLE appointment ALTER url SET DEFAULT 'unnecessary'";
            string fka = "SET FOREIGN_KEY_CHECKS=0";
            MySqlConnection c = new MySqlConnection(DataManager.conString);
            c.Open();
            
            MySqlCommand Title = new MySqlCommand(title, c);
            Title.ExecuteNonQuery();
            MySqlCommand Url = new MySqlCommand(url, c);
            Url.ExecuteNonQuery();

            MySqlCommand Descrip = new MySqlCommand(descrip, c);
            Descrip.ExecuteNonQuery();
            MySqlCommand Location = new MySqlCommand(location, c);
            Location.ExecuteNonQuery();
            MySqlCommand Contact = new MySqlCommand(contact, c);
            Contact.ExecuteNonQuery();
            MySqlCommand Keys = new MySqlCommand(fka, c);
            Keys.ExecuteNonQuery();

            c.Close();
            Application.Run(new LogIn());
        }
    }
}
