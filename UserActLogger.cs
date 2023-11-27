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
        public static void writeUserLogInToLog(string userName, bool authPassed)
        {
            string path = "log.text";
            if (authPassed)
            {
                string log = $"User with username of {userName} logged in at {DataManager.createTimeStamp()}" + Environment.NewLine;
                File.AppendAllText(path, log);
            }
            else
            {
                string log =$"User with a name of {userName} failed to log in at {DataManager.createTimeStamp()}" + Environment.NewLine;
                File.AppendAllText(path, log);
            }

        }
    }
}
