using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListBook_dbText
{
     class Logger
    {
        
        
        public static void LoggerWrite(book = new Books)
        {
            
                
            string mypath = @"Log.txt";
            using (StreamWriter streamWriter = new StreamWriter(mypath))
            {
                foreach (var item in value)
                {
                    streamWriter.Write(item);
                }
                
            }
        }
        public static void LoggerRead(object value)
        {
            string mypath = @"Log.txt";
            using (StreamReader streamReader = new StreamReader(mypath))
            {
                mypath = streamReader.ReadToEnd();
            }
        }
    }
}
