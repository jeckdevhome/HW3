using BookStoreMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreMvc.Services
{
    interface IBookService
    {
        List<BookViewModel> GetAll();
        BookViewModel GetById(string booknumber);
        void AddNewBook(BookViewModel model);
        void RemoveBook(string booknumber);
        void UpdateBook(BookViewModel model);
    }
}
