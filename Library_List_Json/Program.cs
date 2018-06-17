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
            Library library = new Library();
            library.Add();
            Logger logger = new Logger();
            logger.writelog(library);//??


            Console.ReadLine();
        }
    }
}
