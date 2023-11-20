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
    public struct SchedReport
    {
        public int uID;
        public string userName;
        public string type;
        public string startTime;
        public string endTime;
        public string customer;
    }
    public partial class SchedulesReport : Form
    {
        public SchedulesReport()
        {
            InitializeComponent();
           schedGrid.DataSource = schedReport();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static Array schedReport()
       {
            Dictionary<int, Hashtable> schedRep = DataManager.getAppointments();
            var appArray = from row in schedRep
                           select new
                           {
                               Consultant = row.Value["userName"],
                               Customer = row.Value["customerName"],
                               Type = row.Value["type"],
                               Start = DataManager.convertToTimeZone(row.Value["Start"].ToString()),
                               End = DataManager.convertToTimeZone(row.Value["End"].ToString())
                           };
            return appArray.ToArray();
       }
    }
}
