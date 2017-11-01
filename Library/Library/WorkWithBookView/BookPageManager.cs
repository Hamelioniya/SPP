using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class BookPageManager : IBookManager
    {
        public int numOfPage { get; set; }

        public string[] CreateListOfBooks(IBDManager fileReader)
        {
            string fileInformation = fileReader.ReadInformation("Books.txt");
            string[] allBooksInformation = fileInformation.Split(';');

            String[] pageOfBooks;
            int startBookNumber, endBookNumber;
            int j = 1;

            double sizeOfCatalog = (double)allBooksInformation.Length / 10;
            int fullPages = (int)sizeOfCatalog;
            double notFullPages = sizeOfCatalog - fullPages;

            if (notFullPages != 0)
                fullPages++;

            if (numOfPage * 10 >= allBooksInformation.Length)
                numOfPage = fullPages;
            if (numOfPage * 10 <= 0)
                numOfPage = 1;

            startBookNumber = (numOfPage - 1) * 10;

            if ((numOfPage == fullPages) && (notFullPages != 0))
                endBookNumber = allBooksInformation.Length;
            else
                endBookNumber = numOfPage * 10;

            pageOfBooks = new String[endBookNumber - startBookNumber];

            if (allBooksInformation.Length > 1)
                pageOfBooks[0] = (startBookNumber + 1).ToString() + ".\n" + allBooksInformation[0];
            else
                pageOfBooks[0] = allBooksInformation[0];

            for (int i = startBookNumber+1; i < endBookNumber; i++)
            {
                pageOfBooks[j] = "\n" + (i + 1) + ". " + allBooksInformation[i];
                j++;
            }

            return pageOfBooks;
        }
    }
}
