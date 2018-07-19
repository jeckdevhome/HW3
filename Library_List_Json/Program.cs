using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_List_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Library library = new Library();
            library.Add();
            library.Add();
            Logger logger = new Logger();
            logger.writelog(library.books); //??
            var allbooks = library.ShowAll().ToString();
            Console.WriteLine(library.ShowAll());
            Console.WriteLine(allbooks);
            logger.readlog();


            Console.ReadLine();
        }
    }
}
