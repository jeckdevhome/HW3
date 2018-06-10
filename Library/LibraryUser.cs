using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class LibraryUser : IlibraryUser
    {
        public LibraryUser()
        {

        }
        public LibraryUser(string firstName, string lastName, int id, int booksLimit, int phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            BooksLimit = booksLimit;
            Phone = phone;
        }
        string FirstName, LastName; int Id, Phone;
        static int BooksLimit = 0;
        private string[] BookList = new string[BooksLimit] {"Kykish", "Myakish", "Bilbo", "LEGO: Manual"}; 
        public string this[int index_var]
        {
            get
            {
                string temp;
                if(index_var >=0 && index_var < BookList.Length - 1)
                {
                    temp = BookList[index_var];
                }
                else
                {
                    temp = "";
                }
                return temp;
            }
            set
            {
                if(index_var >=0 && index_var < BookList.Length - 1)
                {
                    BookList[index_var] = value;
                }
            }
        } // indexer
        string EntrBookNme; //need read from keyboard, will do to be as a method
        public void ConvertName()
        {
            Console.WriteLine("Enter Name of book");
            EntrBookNme = Convert.ToString(Console.ReadLine());
        }
        public void Show()
        {
            foreach(var item in BookList)
            {
                Console.WriteLine("book name: {0}", item);
            }
            
        }
        public void AddBook()
        {
            Array.Resize(ref BookList, BookList.Length + 1);
            BookList[BookList.Length - 1] = "Books";

        }
        public void BookInfo()
        {
            Console.WriteLine(BookList.ToString());
        }
        public void BooksCount()
        {

        }
        public void RemoveBook()
        {

        }

    }
}
