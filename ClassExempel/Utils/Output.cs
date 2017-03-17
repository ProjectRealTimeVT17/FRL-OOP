using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassExempel.Delegate;

namespace ClassExempel.Utils
{
    class Output
    {
        public string ReportToBoss1(object sender, EventArgs message)
        {
            WriteToConsoleEventArgs args = (WriteToConsoleEventArgs)message;

            Console.WriteLine("Boss 1: " + args.Message);
            return args.Message;
        }

        public string ReportToBoss2(object sender, EventArgs message)
        {
            WriteToConsoleEventArgs args = (WriteToConsoleEventArgs)message;

            Console.WriteLine("Boss 2: " + args.Message);
            return args.Message;
        }
    }
}
