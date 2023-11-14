using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace C969PA
{
    class DataManager
    {
        public static string conString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        public static string createTimeStamp()
        {
            return DateTime.Now.ToString("u");
        }
    }
}
