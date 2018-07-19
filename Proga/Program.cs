using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proga.Servies;

namespace Proga
{
    class Program
    {
        static void Main(string[] args)
        {
            var buildservice = new BildingServices();
            var showall = buildservice.GetAll();
            foreach(var item in showall)
            {
                Console.WriteLine("{0} {1}", item.Floor, item.Price);
            }


            Console.ReadLine();
        }
    }
}
