using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBook_dbText
{
    interface ILibrary
    {
        void AddBook(string name, string author);
        void RemoveBook(string name, string author);
        List<Books> ShowAll();
        List<Books> FindByName(string name);
        List<Books> FindByAuthor(string author);
        bool CheckIfExist(string name, string author);
    }
}
