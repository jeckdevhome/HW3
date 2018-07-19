using LinQ_.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_.Reposytory
{
    interface IMyRequest
    {
        List<Person> GetAll();
        Person GetPersonById(int Id);
        void AddPerson(Person person);

    }
}
