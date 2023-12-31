﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;

namespace C969PA
{
    class DataManager
    {
        private static Dictionary<int, Hashtable> Appointments = new Dictionary<int, Hashtable>();
        private static int CurrentUserId;
        private static string CurrentUserName;
        public static string conString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        public static string createTimeStamp()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        public static int getCurrentUserID()
        {
            return CurrentUserId;
        }
        public static void setCurrentUserID(int currentuID)
        {
            CurrentUserId = currentuID;
        }
        public static string getCurrentUserName()
        {
            return CurrentUserName;
        }

        public static void setCurrentUsername(string currUName)
        {
            CurrentUserName = currUName;
        }

        public static Dictionary<int, Hashtable> getAppointments()
        {
            return Appointments;
        }

        public static void setAppointments(Dictionary<int, Hashtable> appointments)
        {
            Appointments = appointments;
        }

        public static int newID(List<int> idList)
        {
            int highestID = 0;
            foreach (int id in idList)
            {
                if (id > highestID)
                {
                    highestID = id;
                }
            }
            return highestID+1;
        }

        public static int createID(string table)
        {
            MySqlConnection c = new MySqlConnection(conString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand($"Select {table+"ID"} from {table}",c );
            MySqlDataReader dr = cmd.ExecuteReader();
            List<int> idList = new List<int>();
            while(dr.Read())
            {
                idList.Add(Convert.ToInt32(dr[0]));
            }
            dr.Close();
            c.Close();
            return newID(idList);
        }

        public static string convertToTimeZone(string dateTime)
        {
            DateTime utcTime = DateTime.Parse(dateTime.ToString());
            DateTime localTime = utcTime.ToLocalTime();
            return localTime.ToString("MM/dd/yyyy hh:mm tt");
        }

        static public int createRecord(string timestamp, string userName, string table, string partOfQuery, int userId = 0)
        {
            int recId = createID(table);
            string recInsert;
            if (userId == 0)
            {
                recInsert = $"INSERT INTO {table}" +
                $" VALUES ('{recId}', {partOfQuery}, '{timestamp}', '{userName}', '{timestamp}', '{userName}')";
            }
            else
            {
                recInsert = $"INSERT INTO {table} (appointmentId, customerId, start, end, type, userId, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                $" VALUES ('{recId}', {partOfQuery}, '{userId}', '{timestamp}', '{userName}', '{timestamp}', '{userName}')";
            }

            MySqlConnection c = new MySqlConnection(conString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(recInsert, c);
            cmd.ExecuteNonQuery();
            c.Close();

            return recId;
        }
        static public int findCustomer(string customerName)
        {
            string query = $"Select customerID FROM customer Where customerName='{customerName}'";
            MySqlConnection c = new MySqlConnection(conString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int cID = Convert.ToInt32(dr[0]);
            dr.Close();
            c.Close();
            return cID;
        }
    }
}
