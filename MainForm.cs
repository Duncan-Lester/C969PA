using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969PA
{
    public partial class MainForm : Form
    {
        public LogIn loginForm;
        public MainForm()
        {
            InitializeComponent();
            appCalendar.DataSource = getCalendar(monthRadio.Checked);
            customerGrid.DataSource = getCustomers();
            reminder(appCalendar);
        }

        static public void reminder(DataGridView cal)
        {
            foreach (DataGridViewRow row in cal.Rows)
            {
                DateTime now = DateTime.UtcNow;
                DateTime start = DateTime.Parse(row.Cells[2].Value.ToString()).ToUniversalTime();
                TimeSpan timeLeft = now - start;
                if (timeLeft.TotalMinutes >= -15 && timeLeft.TotalMinutes < 1)
                {
                    MessageBox.Show($"Reminder: There is a meeting with {row.Cells[4].Value} at {row.Cells[2].Value}.");
                }
            }
        }

        static public Array getCalendar(bool monthView)
        {
            MySqlConnection con = new MySqlConnection(DataManager.conString);
            con.Open();
            string query = $"Select customerID, type, start, end, appointmentId, userId From appointment Where userid = '{DataManager.getCurrentUserID()}'";
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader dr = com.ExecuteReader();

            Dictionary<int, Hashtable> apps = new Dictionary<int, Hashtable> ();
            while (dr.Read())
            {
                Hashtable appointment = new Hashtable();
                appointment.Add("customerId", dr[0]);
                appointment.Add("type", dr[1]);
                appointment.Add("Start", dr[2]);
                appointment.Add("End", dr[3]);
                appointment.Add("userId", dr[5]);

                apps.Add(Convert.ToInt32(dr[4]), appointment);
                
            }
            dr.Close();
            foreach (var app in apps.Values){
                query = $"SELECT userName FROM user WHERE userId = '{app["userId"]}'";
                com = new MySqlCommand(query, con);
                dr = com.ExecuteReader();
                dr.Read();
                app.Add("userName", dr[0]);
                dr.Close();
            }
            foreach (var app in apps.Values)
            {
                query = $"Select customerName From customer Where customerId = '{app["customerId"]}'";
                com = new MySqlCommand(query, con);
                dr = com.ExecuteReader();
                dr.Read();
                app.Add("customerName", dr[0]);
                dr.Close();
            }
            Dictionary<int, Hashtable> parsedApps = new Dictionary<int, Hashtable>();
            foreach (var app in apps)
            {
                DateTime start = DateTime.Parse(app.Value["Start"].ToString());
                DateTime end = DateTime.Parse(app.Value["End"].ToString());
                DateTime today = DateTime.UtcNow;

                if (monthView)
                {
                    DateTime firstofMonth = new DateTime(today.Year, today.Month, 1);
                    DateTime lastofMonth = firstofMonth.AddMonths(1).AddDays(-1);
                    if (start >=firstofMonth && end <lastofMonth)
                    {
                        parsedApps.Add(app.Key, app.Value);
                    }
                }
                else
                {
                    DateTime sun = today.AddDays(-(int)today.DayOfWeek);
                    DateTime sat = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Saturday);

                    if(start >= sun && end < sat)
                    {
                        parsedApps.Add(app.Key, app.Value);
                    }
                }
            }
            DataManager.setAppointments(apps);

            // makes final DataSource to bind to the calendar and show user.
            var appArray = from row in parsedApps 
            select new {
                              AppointmentID = row.Key,
                              Type = row.Value["type"],
                              StartTime = DataManager.convertToTimeZone(row.Value["Start"].ToString()),
                              EndTime = DataManager.convertToTimeZone(row.Value["End"].ToString()),
                              Customer = row.Value["customerName"],
                        };
            con.Close();
            return appArray.ToArray();
        }
        public void updateCal()
        {
            appCalendar.DataSource= getCalendar(monthRadio.Checked);
        }

        static public Array getCustomers()
        {
            MySqlConnection con = new MySqlConnection(DataManager.conString);
            con.Open();
            string query = $"Select customerID, customerName, addressID From customer";
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader dr = com.ExecuteReader();

            Dictionary<int, Hashtable> customers = new Dictionary<int, Hashtable>();
            while (dr.Read())
            {
                Hashtable cust = new Hashtable();
                cust.Add("customerId", dr[0]);
                cust.Add("customerName", dr[1]);
                cust.Add("addressId", dr[2]);
                customers.Add(Convert.ToInt32(dr[0]), cust);
            }
            dr.Close();
            foreach (var customer in customers.Values)
            {
                query = $"SELECT address, phone FROM address WHERE addressId = '{customer["addressId"]}'";
                com = new MySqlCommand(query, con);
                dr = com.ExecuteReader();
                dr.Read();
                customer.Add("address", dr[0]);
                customer.Add("phone", dr[1]);
                dr.Close();
            }
            //same final array logic as above, but to make customers
            var custArray = from row in customers
                           select new
                           {
                               CustomerID = row.Key,
                               Name = row.Value["customerName"],
                               Address = row.Value["address"],
                               Phone = row.Value["phone"],
                           };
            con.Close();
            return custArray.ToArray();

        }
        
        public void updateCustomers()
        {
            customerGrid.DataSource = getCustomers();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            loginForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void updCust_Click(object sender, EventArgs e)
        {
            string currName = $"{customerGrid.CurrentRow.Cells["Name"].Value}";
            string currPhone = $"{customerGrid.CurrentRow.Cells["Phone"].Value}";
            string currAddress = $"{customerGrid.CurrentRow.Cells["Address"].Value}";
            UpdateCustomer updateCustomer = new UpdateCustomer(currName,currPhone,currAddress);
            updateCustomer.Show();
        }

        private void delCust_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Wait! This operation cannot be undone!", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection(DataManager.conString);
                con.Open();
                //delete from cust
                string custUpdate = $"DELETE FROM customer" +
                    $" WHERE customerName= '{customerGrid.CurrentRow.Cells["Name"].Value}'";
                MySqlCommand com = new MySqlCommand(custUpdate, con);
                int custUpdated = com.ExecuteNonQuery();

                // delete from address
                string addUpdate = $"Delete From address" +
                $" Where address= '{customerGrid.CurrentRow.Cells["Name"].Value}'";
                com = new MySqlCommand(addUpdate, con);
                int addUpdated = com.ExecuteNonQuery();

                con.Close();
                updateCustomers();
            }
        }

        private void addApp_Click(object sender, EventArgs e)
        {
            string customer= $"{customerGrid.CurrentRow.Cells["Name"].Value}";
            AddApt addApt = new AddApt(customer);
            addApt.Show();
        }
        private void updApp_Click(object sender, EventArgs e)
        {
            string currCust = $"{appCalendar.CurrentRow.Cells["Customer"].Value}";
            string currType = $"{appCalendar.CurrentRow.Cells["Type"].Value}";
            string currStart = $"{appCalendar.CurrentRow.Cells["StartTime"].Value}";
            string currEnd = $"{appCalendar.CurrentRow.Cells["EndTime"].Value}";
            UpdateApt updateApt = new UpdateApt(currCust, currType,currStart,currEnd);
            updateApt.Show();
        }
        private void delApp_Click(object sender, EventArgs e)
        {
            // del app with confirmation
        }
        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateCal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateCustomers();
        }
    }
}
