using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Library_List_Json
{
    class Logger
    {
        string mypath = @"log.json";
        public  void writelog(Books classes)
        {
            string json = JsonConvert.SerializeObject(classes);
            using (StreamWriter fs = new StreamWriter(mypath))
            {
                fs.Write(json);
            }
        }
        public void readlog()
        {
            using (StreamReader fr = new StreamReader(mypath))
            {
                Console.WriteLine(fr.ReadToEnd()); 
            }
        }

    }
}
