using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
     class Bilding
    {
        public int Id { get; set; }
        public int BildngTypeId { get; set; }
        public BildingType BildingType {get;set;}
        public double Square { get; set; }
        public int Rooms { get; set; }
        public decimal Price { get; set; }
        public int Floor { get; set; }
    }
}
