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
            MyDictionary.Add('f', new int[] { 0,0,1,0 });
            MyDictionary.Add('g', new int[] { 1,1,0 });
            MyDictionary.Add('h', new int[] { 0,0,0,0 });
            MyDictionary.Add('i', new int[] { 0,0 });
            MyDictionary.Add('j', new int[] { 0,1,1,1 });
            MyDictionary.Add('k', new int[] { 1,0,1 });
            MyDictionary.Add('l', new int[] { 0,1,0,0 });
            MyDictionary.Add('m', new int[] { 1,1 });
            MyDictionary.Add('n', new int[] { 1,0 });
            MyDictionary.Add('o', new int[] { 1,1,1 });
            MyDictionary.Add('p', new int[] { 0,1,1,0 });
            MyDictionary.Add('q', new int[] { 1,1,0,1 });
            MyDictionary.Add('r', new int[] { 0,1,0 });
            MyDictionary.Add('s', new int[] { 0,0,0 });
            MyDictionary.Add('t', new int[] { 1 });
            MyDictionary.Add('u', new int[] { 0,0,1 });
            MyDictionary.Add('v', new int[] { 0,0,0,1 });
            MyDictionary.Add('w', new int[] { 0,1,1 });
            MyDictionary.Add('x', new int[] { 1,0,0,1 });
            MyDictionary.Add('y', new int[] {1,0,1,1 });
            MyDictionary.Add('z', new int[] { 1,1,0,0 });

            MyDictionary.Add('1', new int[] { 0,1,1,1,1 });
            MyDictionary.Add('2', new int[] { 0,0,1,1,1 });
            MyDictionary.Add('3', new int[] { 0,0,0,1,1 });
            MyDictionary.Add('4', new int[] { 0,0,0,0,1 });
            MyDictionary.Add('5', new int[] { 0,0,0,0,0 });
            MyDictionary.Add('6', new int[] { 1,0,0,0,0 });
            MyDictionary.Add('7', new int[] { 1,1,0,0,0 });
            MyDictionary.Add('8', new int[] { 1,1,1,0,0 });
            MyDictionary.Add('9', new int[] { 1,1,1,1,0 });
            MyDictionary.Add('0', new int[] { 1,1,1,1,1 });
        }
       
    }
}
