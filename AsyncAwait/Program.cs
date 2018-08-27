using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncAwait.Repository;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var repos = new Repos();
            var showAll = repos.GetAll();
            foreach(var item in showAll)
            {
                Console.WriteLine("in data : {0} {1}",item.Name,item.LastName);
            }
            Console.ReadLine();
        }
        async static void Middle()
        {

        }
    }
}
