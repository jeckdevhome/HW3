using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BookStoreMvc.Domain;

namespace BookStoreMvc.Data
{
    public class AppDbContext : DbContext
    {
        public  DbSet<Book> Books {get;set;}

    }
}