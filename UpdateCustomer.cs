using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969PA
{
    public partial class UpdateCustomer : Form
    {
        public string oldName = "";
        public string oldAddress = "";
        public MainForm mainFormObject;
        public UpdateCustomer()
        {
            InitializeComponent();
        }
        public UpdateCustomer(string name, string addy, string phoneNumber)
        {
            InitializeComponent();
            nameBox.Text = name;
            oldName = name;
            addressBox.Text = addy;
            oldAddress = addy;
            phoneNumberBox.Text = phoneNumber;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveCustomerButton_Click(object sender, EventArgs e)
        {
            MySqlConnection c = new MySqlConnection(DataManager.conString);
            c.Open();

            //update customer Name
            string custupdate = $"Update customer " +
                $"Set customerName = '{nameBox.Text}' " +
                $"Where customerName = '{oldName}'";
            MySqlCommand com= new MySqlCommand(custupdate, c);
            com.ExecuteNonQuery();
            //update Address Value and Phone
            string addupdate = $"Update address " +
                $"Set address= '{addressBox.Text}',phone= '{phoneNumberBox.Text}' " +
                $"Where address = '{oldAddress}'";
            MySqlCommand cmd = new MySqlCommand(custupdate, c);
            cmd.ExecuteNonQuery();
            MySqlCommand cmd2= new MySqlCommand(addupdate, c);
            cmd2.ExecuteNonQuery();
            c.Close();
            mainFormObject.updateCustomers();
            Close();

        }

    }
}
