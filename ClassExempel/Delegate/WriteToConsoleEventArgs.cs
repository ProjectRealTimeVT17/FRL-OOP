using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExempel.Delegate
{
    public class WriteToConsoleEventArgs : EventArgs
    {
        public string Message { get; set; }
        public int IntMessage { get; set; }
    }
}
