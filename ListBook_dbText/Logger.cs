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
        
        public void LoggerWrite()
        {
            string mypath = @"c:\Log.txt";
            StreamWriter streamWriter = new StreamWriter(mypath, Encoding.UTF8);
        }
        public void LoggerRead()
        {

        }
    }
}
