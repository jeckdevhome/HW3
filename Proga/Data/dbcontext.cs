﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga.Data
{
     class dbcontext : DbContext
    {
        public DbSet<Bilding> Bildings { get; set; }
        public DbSet<BildingType> bildingTypes { get; set; }
    }
}
