﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class FirstEventArgs : EventArgs
    {
    }

    public class SumOfAllElementsEventArgs : EventArgs
    {
        public int SumOfAllElements { get; set; }
    }
}
