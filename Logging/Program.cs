using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {

            EventLog eventLog = new EventLog();
            if (!EventLog.SourceExists("mySource1"))
            {
                EventLog.CreateEventSource("mySource", "Application");
            }

            eventLog.Source = "mySource";
            int eventID = 8;
            eventLog.WriteEntry("my message", EventLogEntryType.Warning, eventID);
            Console.WriteLine("Done");
            Console.ReadKey();
            
           
        }
    }
}
