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
            string myword = Convert.ToString(Console.ReadLine());
            char[] tomorze = myword.ToCharArray();
            foreach(var item in tomorze)
            {

            }
            

            Console.ReadLine();
        }
    }
}
