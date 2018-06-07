using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morze
{
    //создать программу которая конвертирует введеный текст с клавиатуры в азбуку морзе(Console.beep)
    //использовать Dictionary
    //1.получить текст
    //2.Конвертировать в азбуку
    //3.посигнализировать
    class Program
    {
        public void Beep()
        {
            if 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Enter same text to convert in morze");
            var mydictionary = new Dictionare_Morze();
            mydictionary.dowork();
            //mydictionary.MyDictionary.Equals('h');
            string myword = Convert.ToString(Console.ReadLine());
            char[] tomorze = myword.ToCharArray();
            for (int i = 0; i < tomorze.Length; i++)
            {
                   if (mydictionary.MyDictionary.ContainsKey(tomorze[i]))
                   {
                        Console.WriteLine("the tes to find <Tkey>");
                   }
                   else
                   {
                    Console.WriteLine("not use");
                   }
            }
            
            Console.ReadLine();
        }
    }
}
