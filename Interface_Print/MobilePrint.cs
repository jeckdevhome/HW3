using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Print
{
    class MobilePrint : Iprintble
    {
        string Name;
        public MobilePrint(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine(Name); 
        }
    }
}
