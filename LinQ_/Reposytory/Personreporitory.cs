using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinQ_.Domain;
using LinQ_.Data;

namespace LinQ_.Reposytory
{
    class Personreporitory : IMyRequest
    {
        private readonly AppDataContext _context;
        public Personreporitory()
        {
            _context = new AppDataContext();
        }
        public void AddPerson(Person person)
        {
           _context.Person.Add(person);
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetPersonById(int id)
        {
            //return from person in _context.Persons

            _context.Person.SelectMany(Person.Equals(objA).id);
                 
        }
    }
}
