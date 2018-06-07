using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            foreach (var item in library.ShowAll())
            {
                Console.WriteLine("{0} {1}",item.Name, item.Author);
            }
            library.Add("steel pats", "Garry Garison");
            foreach (var item in library.ShowAll())
            {
                Console.WriteLine("\n Books{0} {1}", item.Name, item.Author);
            }
            Console.ReadLine();
        }
    }
}
