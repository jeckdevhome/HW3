using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_.Domain
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }



    }


    //public List<Students> GetAll(string groupname)
    //public int GroupId {get;set}
    //public Group Group {get;set;}
    //in repositore method _context.Studetn.Include("Group")
    //return _contex.Include("Students").Where(_ => _.Name == groupname)
            //.selectMany(_ => _.Students).ToList();
}
