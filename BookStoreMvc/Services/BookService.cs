using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreMvc.Domain;
using BookStoreMvc.Models;
using BookStoreMvc.Repository;

namespace BookStoreMvc.Services
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepositoryr;
        private IhashidsService _hashidsService;
        

        public BookService()
        {
            _bookRepositoryr = new BookRepository();
            _hashidsService = new HashidsService();
        }

        public void AddNewBook(BookViewModel model)
        {
            Book newBook = new Book
            {
                Name = model.Name,
                Author = model.Author,
                Price = model.Price,
                Reiting = model.Reiting
            };
            _bookRepositoryr.AddBook(newBook);
        }

        public List<BookViewModel> GetAll()
        {
            List<Book> books = _bookRepositoryr.GetAll();
            return books.Select(_ => new BookViewModel {
            BookNumber  = _hashidsService.Enrypt(_.Id),
            Name = _.Name,
            Author = _.Author,
            Price = _.Price,
            Reiting = _.Reiting

            }).ToList();
        }

        public BookViewModel GetById(string booknumber)
        {
            int bookId = _hashidsService.Decrypt(booknumber);
            Book book = _bookRepositoryr.GetById(bookId);
            return new BookViewModel
            {
                Author = book.Author,
                BookNumber = booknumber,
                Name = book.Name,
                Price = book.Price,
                Reiting = book.Reiting
            };
        }

        public void RemoveBook(string booknumber)
        {
            int bookId = _hashidsService.Decrypt(booknumber);
            _bookRepositoryr.Remove(bookId);
        }

        public void UpdateBook(BookViewModel model)
        {
            int bookId = _hashidsService.Decrypt(model.BookNumber);
            Book oldBook = _bookRepositoryr.GetById(bookId); //delete
            oldBook.Name = model.Name;//
            oldBook.Author = model.Author;//
            oldBook.Price = model.Price;//

            //Book newBook = new Book
            //{
            //    Id = bookId,
            //    Author = model.Author,
            //    Name = model.Name,
            //    Price = model.Price
            //};
            _bookRepositoryr.UpdateBook(oldBook); //_bookRepositoryr.UpdateBook(newBook);

        }
    }
}