using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp2
{
      class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}
