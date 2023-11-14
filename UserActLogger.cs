using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969PA
{
    internal class UserActLogger
    {
        public static void writeUserLogInToLog(string userName)
        {
            string path = "log.text";
            string log = $"User with username of {userName} logged in at {DataManager.createTimeStamp()}" + Environment.NewLine;
            File.AppendAllText(path, log);
        }
    }
}
