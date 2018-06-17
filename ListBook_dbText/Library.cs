using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListBook_dbText
{
    class Library : ILibrary
    {
        public Library()
        {
            books = new List<Books>();
            books.Add(new Books { Name = "Babauko ", Author = "Me" });
            books.Add(new Books { Name = "Pinokio ", Author = "Me and other" });
        }
        public List<Books> books { get; set; }

        public void AddBook(string name, string author)
        {
            books.Add(new Books { Name = name, Author = author });
            foreach (var item in books)
            {
                Logger.LoggerWrite(item.Author, item.Name);
                
            }

        }
        public void RemoveBook(string name, string author)
        {
            Books foundbook = books.Find(x => x.Author == author && x.Name == name);
            books.Remove(foundbook);
            foreach (var item in books)
            {
                Logger.LoggerWrite(item.Author, item.Name);
                
            }
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
    class Logger
    {
        Library library1 = new Library();

        public static void LoggerWrite(string name, string author)
        {
            //library1.books();


            string mypath = @"Log.txt";
            using (StreamWriter streamWriter = new StreamWriter(mypath))
            {
                foreach (var item in name)
                {
                    streamWriter.Write(item);
                    //streamWriter.Write();
                    continue;
                }
                foreach (var item in author)
                {
                    streamWriter.Write(item);
                    continue;

                }
            }
        }
            public static void LoggerRead(object value)
            {
                string mypath = @"Log.txt";
                using (StreamReader streamReader = new StreamReader(mypath))
                {
                    mypath = streamReader.ReadToEnd();
                }
            }
        }
    }

