using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class WriteAllLines
    {
        public static void ExampleAsync(string location, string output)
        {
           File.WriteAllText(location, output);
        }
        public static async Task InputString()
        {
            string[] lines =
            {
            "First line", "Second line", "Third line"
            };

            await File.WriteAllLinesAsync("WriteLines.txt", lines);
        }

        public static string DownloadString(string address)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(address);

            return reply;
            
        }
    }
}
