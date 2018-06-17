using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBook_dbText
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new Library();
            var use = new Logger();
            user1.AddBook("Bilbo ","Begens ");
            //user1.ShowAll();
            
            foreach(var item in user1.ShowAll())
            {
                Logger.LoggerWrite(item.Author, item.Name);
                Console.WriteLine("Book: {0}, {1}", item.Author, item.Name);
            }
            
            Console.ReadLine();
        }
    }
}
