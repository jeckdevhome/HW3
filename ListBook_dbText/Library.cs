﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBook_dbText
{
    class Library : ILibrary
    {
        public Library()
        {
            books = new List<Books>();
            books.Add(new Books { Name = "Babauko", Author = "Me" });
        }
        private List<Books> books { get; set; }

        public void AddBook(string name, string author)
        {
            books.Add(new Books { Name = name, Author = author });
        }
        public void RemoveBook(string name, string author)
        {
            Books foundbook = books.Find(x => x.Author == author && x.Name == name);
            books.Remove(foundbook);
        }
        public List<Books> FindByName(string name)
        {
            return books.FindAll(x => x.Name == name);
        }
        public List<Books> FindByAuthor(string author)
        {
            return books.FindAll(x => x.Author == author);
        }
        public List<Books> ShowAll()
        {
            return books;
        }
        public bool CheckIfExist(string name, string author)
        {
            return books.Any(x => x.Author == author && x.Name == name);
        }
    }
}
