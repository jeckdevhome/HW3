using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_List_Json
{
    class Books
    {
        public Books(string name, string author)
        {
            Name = name;
            Author = author;
        }
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
