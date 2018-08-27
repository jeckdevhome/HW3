using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncAwait.Domain;
using AsyncAwait.Data;

namespace AsyncAwait.Repository
{
    class Repos : IRepos
    {
        public List<Student> GetAll()
        {
            var context = new AppDbContext();
            var allStudent = context.Students.ToList();
            return allStudent;
        }

        public Student getByName(string Name)
        {
            var context = new AppDbContext();
            var byName = context.Students.ToList();
            return Name;
        }
    }
}
