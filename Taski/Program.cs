using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Taski
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> tresult = new Task<int>(n => Sum((int)n), 10);
            tresult.Start();

            Console.WriteLine("sum is : {0}", tresult.Result);
            Console.ReadLine();
        }
        private static int Sum(int n)
        {
            int sum = 0;
            for(int i = 0; i< n; i++)
            {
                sum += n;
            }
            Thread.Sleep(2000);
            return sum;
        }
    }
}
