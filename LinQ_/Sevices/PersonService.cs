using LinQ_.Domain;
using LinQ_.Reposytory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_.Sevices
{
    class PersonService
    {
        private readonly IMyRequest _myRequest;
        public PersonService()
        {
            _myRequest = new Personreporitory();
        }
        public List<Person> GetFilteredPersons()
        {
            var listper = "";
            return listper;
        }



    }
}
