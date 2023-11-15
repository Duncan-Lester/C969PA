using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace C969PA
{
    public partial class LogIn : Form
    {
        public string message = "The username and password did not match.";
        public LogIn()
        {
            InitializeComponent();
            if (CultureInfo.CurrentUICulture.LCID == 3084) //3084 is lcid for Canadian French
            {
                this.Text = "Se connecter";
                userNameLabel.Text = "nom d'utilisateur";
                passwordLabel.Text = "mot de passe";
                cancelButton.Text = "annuler";
                logInButton.Text = "Se connecter";
                message = "Le nom d'utilisateur et le mot de passe ne correspondent pas.";
            }
        }
        static public int findUser(string userName, string password)
        {
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["localdb"].ConnectionString);
            con.Open();
            MySqlCommand command = new MySqlCommand($"Select userID from user where userName = '{userName}' and password = '{password}'", con);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                DataManager.setCurrentUserID(Convert.ToInt32(reader[0]));
                DataManager.setCurrentUsername(userName);
                reader.Close();
                con.Close();
                //Console.WriteLine(DataManager.getCurrentUserID());
                return 1; 
            }
            return 0;
        }
        private void logInButtonClick(object sender, EventArgs e)
        {
            if (findUser(usernameBox.Text, passwordBox.Text) ==1)
            {
                this.Hide();
                MainForm MainForm = new MainForm();
                MainForm.loginForm = this;
                UserActLogger.writeUserLogInToLog(usernameBox.Text);
                MainForm.Show();
            }
            else
            {
                MessageBox.Show(message);
                passwordBox.Text = "";
            }
        }

        private void cancelButtonClick(object sender, EventArgs e) 
        {
            Close();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
