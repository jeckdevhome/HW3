using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            var canon = new PrinDevice("canon", "Pather1");
            var mobprin = new MobilePrint("mobile printer xerox");
            var printer = new Printer();
            printer.Print(canon);
            printer.Print(mobprin);

            Console.ReadLine();
        }
    }
}
