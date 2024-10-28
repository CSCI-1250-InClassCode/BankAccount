using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Logger
    {
        private List<string> _logEntries = new List<string>();

        public void Log(string message)
        {
            _logEntries.Add(DateTime.Now + ": " +  message);
        }

        public string GetReport()
        {
            string report = string.Empty;

            foreach (var entry in _logEntries) 
            {
                report += entry + "\n";
            }

            return report;
        }
    }
}
