using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class BookAllManager : IBookManager
    {
        public string[] CreateListOfBooks(IBDManager fileReader)
        {
            string allBooksInformation = fileReader.ReadInformation("Books.txt");

            return allBooksInformation.Split(';');
        }
    }
}
