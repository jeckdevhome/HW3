using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class DoWork
    {
        double number_1, number_2;
        public delegate DoWork metr();

        public void doWork()
        {
            Console.WriteLine("Hello in the calculator");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string ss = new string('-', 30);
            Console.WriteLine(ss);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n enter two numbers ");
            Console.ResetColor();
            var calculate = new Calc();
                try
                {
                
                    var enternum = new DoWork();
                    enternum.RreadNumbers();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Wrong types");
                }
            Console.WriteLine("Chose operation");
            Console.WriteLine("1: Add \t2: Extrack \t3: Multiplay \t4: Devide operation");
            string str = Console.ReadLine();
            switch (str)
            {
                case "1":
                case "Add":
                    Console.WriteLine(calculate.Add(number_1, number_2));
                    break;
                case "2":
                case "Extract":
                    Console.WriteLine(calculate.Extract(number_1, number_2)); 
                    break;
                case "3":
                case "Myltiplay":
                    Console.WriteLine(calculate.Multiplay(number_1, number_2));
                    break;
                case "4":
                case "Devide":
                    Console.WriteLine(calculate.Devide(number_1, number_2));
                    break;
                    

                  
                default:
                    Console.WriteLine("default");
                    break;
            }
        }
        public void RreadNumbers()
        {
            try
            {
                var number1 = Convert.ToDouble(Console.ReadLine());
                number_1 = number1;
                var number2 = Convert.ToDouble(Console.ReadLine());
                number_2 = number2;
                Console.WriteLine("you enter {0} number and number two {1}", number_1, number_2);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Wrong types");
                this.RreadNumbers();
            }
        }
    }
}
