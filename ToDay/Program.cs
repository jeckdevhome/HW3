using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDay
{
    class Program
    {
        private object provider;

        
        static void Main(string[] args)
        {
            //List<Employee> GetLastFiveDaysBirthdays = new List<Employee>();

            var list = new List<Employee>()
            {
                { new Employee( "jon", DateTime.Parse("28.06.2018") )},
                { new Employee( "denis", DateTime.Parse("10.06.2018") )}
            };
            var result = new List<Employee>();
            foreach (var item in list) //this.provider.GetAllStaff()
                {
                    if (item.Birthdate.Month == DateTime.Today.Month
                        && (item.Birthdate.Day == DateTime.Today.Day - 1
                        || item.Birthdate.Day == DateTime.Today.Day - 2
                        || item.Birthdate.Day == DateTime.Today.Day - 3
                        || item.Birthdate.Day == DateTime.Today.Day - 4
                        || item.Birthdate.Day == DateTime.Today.Day - 5))
                    result.Add(item);
                 
                Console.WriteLine("ALL user: {0}, and date {1} ", item.UserName, item.Birthdate);
                }
            foreach (var item in result)
            {
                //Console.WriteLine("In Result user: {0}, and date {1} ", item.UserName, item.Birthdate);
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public Employee(string name, DateTime dateTime)
        {
            UserName = name;
            Birthdate = dateTime;
            
        }
        public DateTime Birthdate;
        public string UserName;
    }
}
