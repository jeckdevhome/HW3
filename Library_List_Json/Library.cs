using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_List_Json
{
    class Library : ILibrary
    {
        public List<Books> Books { get; set; }
        Logger logger = new Logger();
        public Library()
        {
            
        }
        public void Add()
        {
            Console.WriteLine("Enter book name");
            string enterValue = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter book Author");
            string enterValue2 = Convert.ToString(Console.ReadLine());
            Books.Add(new Books(enterValue, enterValue2));
            //logger.writelog(Books);
        }
        public void Remove()
        {

        }

    }
}
