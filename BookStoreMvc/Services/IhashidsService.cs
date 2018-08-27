using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreMvc.Services
{
    interface IhashidsService
    {
        string Enrypt(int id);
        int Decrypt(string hashids);
    }
}
