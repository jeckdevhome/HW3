using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LinQ_.Domain;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_.Data
{
    class AppDataContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
    }
}
