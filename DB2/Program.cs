using DB2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( var context = new AppDbContext())
            {
                context.Cars.Add(new domain.Car { Brand = "Lada", Model = "2106" });
                context.SaveChanges();
                var cars = context.Cars.ToList();
                foreach(var car in cars)
                {
                    Console.WriteLine("{0} {1}", car.Brand, car.Model);
                }
                
            }
            


            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
