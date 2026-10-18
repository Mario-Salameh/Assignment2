using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Assignment_2
{
    public static class Helper
    {
        public static int Counter { get; set; }
        public static int IncreaseCounter() { return ++Counter; }
    }
}
