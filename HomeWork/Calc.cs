using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Calc : ICalc
    {
        public Calc()
        {
            
        }
        public double result, value11, value22;

        public double Extract(double value11, double value22)
        {
        result = value11 - value22;
            return result;
        }

        public double Add(double value11, double value22)
        {
            result = value11 + value22;
            return result;
        }
        
    }
}
