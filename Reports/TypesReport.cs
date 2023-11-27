using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969PA.Reports
{
    public partial class TypesReport : Form
    {
        public TypesReport()
        {
            InitializeComponent();
            typeGrid.DataSource = typeReport();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static Array typeReport()
        {
            List<AptReport> aptReports = new List<AptReport>();
            List<Hashtable> aptTypes = new List<Hashtable>();
            SortedList months = new SortedList();
            months.Add(1, "January"); months.Add(2, "February"); months.Add(3, "March"); months.Add(4, "April");
            months.Add(5, "May"); months.Add(6, "June"); months.Add(7, "July"); months.Add(8, "August");
            months.Add(9, "September"); months.Add(10, "October"); months.Add(11, "November"); months.Add(12, "December");
            int rowcount = 0;
            foreach (var apt in DataManager.getAppointments().Values)
            {
                int aptMonth = DateTime.Parse(apt["Start"].ToString()).Month;
                bool duplicate = false;
                foreach (AptReport a in aptReports)
                {
                    if (a.month.ToString() == months[aptMonth].ToString() && a.aptType == apt["type"].ToString())
                    {
                        if (a.aptType == apt["type"].ToString())
                        {
                            duplicate = true;
                            rowcount++;
                        }
                    }

                }

                if (!duplicate)
                {
                    AptReport aptReport = new AptReport();
                    aptReport.month = months[aptMonth].ToString();
                    aptReport.aptType = apt["type"].ToString();
                    aptReport.quantity = DataManager.getAppointments().Where(i => i.Value["type"].ToString() == apt["type"].ToString()
                    && DateTime.Parse(i.Value["Start"].ToString()).Month == aptMonth).Count();
                    // Lambda counts unique month and quantity of each type in unique month
                    aptReports.Add(aptReport);
                }



            }
            var aptArray = from row in aptReports
                           select new
                           {
                               Month = row.month,
                               Type = row.aptType,
                               Quantity = row.quantity,
                           };
            return aptArray.ToArray();
        }
    }
}

namespace C969PA
{
    struct AptReport
    {
        public string month;
        public string aptType;
        public int quantity;
    }
}