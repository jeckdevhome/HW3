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
                    if (mydictionary.MyDictionary.ContainsKey(tomorze[i])) //если текст введен на англ языке будет выдавать сигнал 
                    {
                        //если ключи совподают дальше перебираем какой звук выдать
                        // к примеру  "а" содержит один кароткий и один длинный
                        Console.WriteLine("\nwe find <Tkey> {0}", tomorze[i]);
                        var intByteArray = mydictionary.MyDictionary[tomorze[i]];
                        for (int j = 0; j < intByteArray.Length; j++)
                        {
                            if (intByteArray[j] == 0)
                            {
                                Console.Write(".");
                                Console.Beep(500, 400);
                                continue;
                            }
                            Console.Write("_");
                            Console.Beep(500, 600);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nprobel");
                        Console.Beep(700, 1000);
                    }
                } 
            Console.ReadLine();
        }
    }
}
