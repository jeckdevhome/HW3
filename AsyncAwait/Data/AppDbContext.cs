using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;
using AsyncAwait.Domain;

namespace AsyncAwait.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

    }
}
