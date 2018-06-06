using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Print
{
    class PrinDevice : Iprintble
    {
        public PrinDevice()
        {

        }
        public PrinDevice(string name, string model)
        {
            Name = name;
            Model = model;
        }
        string Name;
        string Model;
        public void Print()
        {
            Console.WriteLine("{0} - {1}", Name, Model);
        }
       
    }
}
