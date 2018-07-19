using DB2.domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }

}
