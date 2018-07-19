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
        public  void writelog(List<Books> classes)
        {
            string json = JsonConvert.SerializeObject(classes);
            using (StreamWriter fs = new StreamWriter(mypath))
            {
                fs.WriteLine(json);
            }
        }
        public void WriteLogJson(List<Books> classes)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"log2.json"))
            using (JsonWriter write = new JsonWriter(sw))
            {
                serializer.Serialize(write, classes);
            }
        }
        public void DataContr()
        {
            Data
        }
        public void readlog()
        {
            using (StreamReader fr = new StreamReader(mypath))
            {
                Console.WriteLine(fr.ReadToEnd());
                //return fr.ReadToEnd();
            }
        }

    }
}
