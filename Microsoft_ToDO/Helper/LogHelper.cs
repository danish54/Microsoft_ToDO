using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_ToDO.Helper
{
    public class LogHelpers
    {
        //Declaration of the file stream and format 
        private static string _logFile = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        public static StreamWriter stream = null;

        //Create a file that will be used to store the log information
        public static void CreateLogFile()
        {
            //create a directory
            string userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string filePath = userDir + "\\source\\repos\\Microsoft_ToDO\\Microsoft_ToDO\\OutPut\\Logs\\";

            //string filePath = @"C:\LogRecords\";

      


            if (Directory.Exists(filePath))
            {
                //stream = File.CreateText(filePath + _logFile + ".log");
                stream = File.AppendText(filePath + _logFile + ".log");
            }
            else
            {
                Directory.CreateDirectory(filePath);
                stream = File.AppendText(filePath + _logFile + ".log");
            }
        }

        //Create a method that can write the information into the log file
        public static void WriteToFile(string Message)
        {
            stream.Write("{0} {1}\t", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            stream.Write("{0}\n", Message);
            stream.Flush();

        }
    }
}