using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga.Data
{
     class Dbcontext : DbContext
    {
        public DbSet<Bilding> Bildings { get; set; }
        public DbSet<BildingType> BildingTypes { get; set; }
    }
}
