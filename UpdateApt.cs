using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace C969PA
{
    public partial class UpdateApt : Form
    {
        public string oldName ="";
        private int aId = 0;
        public UpdateApt()
        {
            InitializeComponent();
        }

        public UpdateApt(string customer, string type, DateTime start, DateTime end, int aID)
        {
            InitializeComponent();
            customerBox.Text = customer;
            oldName = customer;
            typeBox.Text = type;
            startTimePicker.Value = start;
            endTimePicker.Value = end;
            aId = aID;
        }

        private void updAptButton_Click(object sender, EventArgs e)
        {
            // UPDATE
            DateTime newstart = startTimePicker.Value.ToUniversalTime();
            DateTime newend = endTimePicker.Value.ToUniversalTime();

            string newType = typeBox.Text;
            int cID = DataManager.findCustomer(oldName);
            int newCust = DataManager.findCustomer($"{customerBox.Text}");
          
            MySqlConnection c = new MySqlConnection(DataManager.conString);
            c.Open();

            //string oldStart = oldTime.ToString("yyyy-MM-dd HH:mm:ss");
            int uID=DataManager.getCurrentUserID();
            string aptupdate = $"Update appointment SET customerId= '{newCust}', type= '{newType}',start= '{newstart.ToString("yyyy-MM-dd HH:mm:ss")}',end= '{newend.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE appointmentId= '{aId}'";
            MySqlCommand com = new MySqlCommand(aptupdate, c);
            com.ExecuteNonQuery();

            c.Close();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
