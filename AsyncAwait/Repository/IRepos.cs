using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsyncAwait.Domain;

namespace AsyncAwait.Repository
{
    interface IRepos
    {
        List<Student> GetAll();
        Student getByName(string Name);

    }
}
