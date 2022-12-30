using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LogLine
    {
        public string Message(string logLine)
        {
            string []  = "";

            if (logLine == "[ERROR]: Invalid operation")
            {
                message = "Invalid operation";
            }
            else if(logLine == "[WARNING]:  Disk almost full\r\n")
            {
                message = "Disk almost full";
            }

            return message;
            
            
            //throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
        }

        public static string LogLevel(string logLine)
        {
            throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
        }

        public static string Reformat(string logLine)
        {
            throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
        }
    }
}
