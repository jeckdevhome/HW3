using BookStoreMvc.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreMvc.Repository
{
    interface IBookRepository
    {
        List<Book> GetAll();
        List<Book> GetByReting(double rating);
        List<Book> GetByName(string name);
        Book GetById(int id);

        void AddBook(Book book);
        void Remove(int id);
        void UpdateBook(Book book);

    }
}
