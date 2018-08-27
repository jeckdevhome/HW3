using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreMvc.Domain;
using BookStoreMvc.Data;

namespace BookStoreMvc.Repository
{
    public class BookRepository : IBookRepository
    {
        private AppDbContext _context;
        public BookRepository()
        {
            _context = new AppDbContext();
        }
        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public List<Book> GetByName(string name)
        {
            //throw new NotImplementedException();
            Book book = _context.Books.FirstOrDefault(_ => _.Name == name);
            return _context.Books.ToList();
        }

        public List<Book> GetByReting(double rating)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            Book book = _context.Books.FirstOrDefault(_=> _.Id == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book newBook)
        {
            _context.SaveChanges();

            //var oldBook = GetById(newBook.Id);
            //oldBook.Name = newBook.Name;
            //oldBook.Author = newBook.Author;
            //oldBook.Price = newBook.Price;
        }
        public Book GetById(int id)
        {
            return _context.Books.FirstOrDefault(b => b.Id ==id);
        }
    }
}