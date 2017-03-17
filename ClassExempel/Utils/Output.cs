using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExempel.Utils
{
    class Output
    {
        public string ReportToBoss1(string message)
        {
            Console.WriteLine("Boss 1: " + message);
            return message;
        }

        public string ReportToBoss2(string message)
        {
            Console.WriteLine("Boss 2: " + message);
            return message;
        }
    }
}
