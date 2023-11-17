using MySql.Data.MySqlClient;
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

namespace C969PA
{
    public partial class AddApt : Form
    {
        public MainForm main;
        public static bool hasTimeConflict(DateTime start, DateTime end)
        {
            Dictionary<int, Hashtable> theseApts = DataManager.getAppointments();
            foreach (var apt in theseApts.Values)
            {
                if (start < DateTime.Parse(apt["End"].ToString()) && DateTime.Parse(apt["Start"].ToString()) < end)
                {
                    return true;
                }
            }
            return false;
        }
        public AddApt()
        {
            InitializeComponent();
        }
        public AddApt(string customer)
        {
            InitializeComponent();
            customerBox.Text = customer;
            startTimePicker.Value = DateTime.Now;
            endTimePicker.Value = startTimePicker.Value.AddHours(1);
        }

        public static bool isOutOfBizHours(DateTime start, DateTime end)
        {
            DateTime startTime = start;
            DateTime endTime = end;
            DateTime BizStart = DateTime.Today.AddHours(9); //9am to 5pm, no lunch
            DateTime BizEnd = DateTime.Today.AddHours(17);
            if (startTime.TimeOfDay > BizStart.TimeOfDay && start.TimeOfDay < BizEnd.TimeOfDay && endTime.TimeOfDay > BizStart.TimeOfDay && endTime.TimeOfDay < BizEnd.TimeOfDay)
            {
                return false;
            }
            return true;
        }
        private void addAptButton_Click(object sender, EventArgs e)
        {
            string timestamp = DataManager.createTimeStamp();
            int uID = DataManager.getCurrentUserID();
            string uname = DataManager.getCurrentUserName();
            DateTime start = startTimePicker.Value.ToUniversalTime();
            DateTime end = endTimePicker.Value.ToUniversalTime();
            int cID = DataManager.findCustomer($"{customerBox.Text}");
            string blank = "blank";
            try
            {
                if (hasTimeConflict(start, end))
                {
                    throw new Exception();
                }
                else
                {
                    try
                    {
                        if (isOutOfBizHours(startTimePicker.Value, endTimePicker.Value))
                        {
                            throw new Exception("Oops, Appointments need to be inside business hours from 9am to 5pm!");
                        }
                        else
                        {
                            DataManager.createRecord(timestamp, uname, "appointment", $"'{cID}','{start.ToString("yyyy-MM-dd HH:mm:ss")}','{end.ToString("yyyy-MM-dd HH:mm:ss")}','{typeBox.Text}'",uID);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                }
            }
            catch (Exception){
                MessageBox.Show("Oops, your appointment time conflicts with another scheduled appointment.");
            };
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
