using HashidsNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreMvc.Services
{
    public class HashidsService : IhashidsService
    {
        private Hashids _hash;

        public HashidsService()
        {
            _hash = new Hashids("Slon");
        }
        public int Decrypt(string hashids)
        {
           return _hash.Decode(hashids).First();
        }

        public string Enrypt(int id)
        {
            return _hash.Encode(id);
        }
    }
}