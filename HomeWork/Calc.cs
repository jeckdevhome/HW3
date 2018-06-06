using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Calc : ICalc
    {
        public double result; 
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
        public double Multiplay(double value1, double value2)
        {
            result = value1 * value2;
            return result;
        }
        public double Devide(double value1, double value2)
        {
            result = value1 / value2;
            return result;
        }
    }
}
