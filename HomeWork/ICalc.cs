using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public delegate void RetRestoCalc(double value1, double value2);
    interface ICalc
    {
        double Add(double value1, double value2);
        double Extract(double value1, double value2);

    }
}
