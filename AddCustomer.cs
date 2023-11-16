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
    public partial class AddCustomer : Form
    {
        public MainForm main;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            string uName = DataManager.getCurrentUserName();

            {
                string timestamp = DataManager.createTimeStamp();
                string userName = DataManager.getCurrentUserName();
                if (string.IsNullOrEmpty(countryBox.Text) ||
                    string.IsNullOrEmpty(cityBox.Text) ||
                    string.IsNullOrEmpty(addressBox.Text) ||
                    string.IsNullOrEmpty(zipBox.Text) ||
                    string.IsNullOrEmpty(phoneNumberBox.Text) ||
                    string.IsNullOrEmpty(nameBox.Text) ||
                    (checkBox1.Checked == false && checkBox2.Checked == false))
                {
                    MessageBox.Show("Please fill out all fields");
                }
                else
                {
                    int countryId = DataManager.createRecord(timestamp, userName, "country", $"'{countryBox.Text}'");
                    int cityId = DataManager.createRecord(timestamp, userName, "city", $"'{cityBox.Text}', '{countryId}'");
                    int addressId = DataManager.createRecord(timestamp, userName, "address", $"'{addressBox.Text}', '', '{cityId}', '{zipBox.Text}', '{phoneNumberBox.Text}'");
                    int lastId= DataManager.createRecord(timestamp, userName, "customer", $"'{nameBox.Text}', '{addressId}', '{(checkBox1.Checked ? 1 : 0)}'");

                    Close();
                    
                }
            }
        }
    }
}
