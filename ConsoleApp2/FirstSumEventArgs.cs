using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class FirstSumEventArgs : EventArgs
    {
        public int FirstElement { get; set; }
        public int SumOfAllElements { get; set; }
    }
}
