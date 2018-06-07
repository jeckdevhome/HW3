using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    class Dictionare_Morze
    {
        public Dictionary<char, int[]> MyDictionary = new Dictionary<char, int[]>();
        public void dowork()
        { 

        //Dictionary<char, int[]> MyDictionary = new Dictionary<char, int[]>();
            MyDictionary.Add('a', new int[]{ 0,1});
            MyDictionary.Add('b', new int[]{ 1,0,0,0});
            MyDictionary.Add('c', new int[]{ 1,0,1,0});
            MyDictionary.Add('d', new int[]{ 1,0,0});
            MyDictionary.Add('e', new int[]{ 0});
        }
    }
}
