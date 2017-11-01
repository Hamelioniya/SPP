using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class FileReader : IBDManager
    {
        public string ReadInformation(string fileName)
        {
            if(!File.Exists(fileName))
            {
                return "No file with books!";
            }
            return File.ReadAllText(fileName);
        }
    }
}
