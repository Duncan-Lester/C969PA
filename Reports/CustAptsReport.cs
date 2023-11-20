using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969PA.Reports
{
    public struct CustomerRepo
    {
        public string customerName;
        public int numApps;
    }
    public partial class CustAptsReport : Form
    {
        public CustAptsReport()
        {
            InitializeComponent();
            aptsCustView.DataSource = AptReport();
        }
        public static DataTable AptReport()
        {
            Dictionary<int, Hashtable> apts = DataManager.getAppointments();

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Customer Name");
            dt.Columns.Add("Apts Booked");
            // Lambda expression finds each distinct customer from the apts Collection<>
            IEnumerable<string> customers = apts.Select(i => i.Value["customerName"].ToString()).Distinct();

            foreach (string cus in customers)
            {
                DataRow r = dt.NewRow();
                r["Customer Name"] = cus;
                //Lambda expression counts num of apts under each customer
                r["Apts Booked"] = apts.Where(i => i.Value["customerName"].ToString()== cus.ToString()).Count().ToString();
                dt.Rows.Add(r);
            }
            return dt;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
