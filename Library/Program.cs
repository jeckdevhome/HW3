using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            LibraryUser TOM = new LibraryUser("Tommy", "Finger", 001, 5, 102);
            LibraryUser TiM = new LibraryUser("Tim", "leg", 003, 3, 103);
            TOM.BookInfo();
            TOM.Show();
            TOM.BooksCount();
            TiM.BooksCount();
            TiM.Show();
            Console.ReadLine();
        }
    }
}
