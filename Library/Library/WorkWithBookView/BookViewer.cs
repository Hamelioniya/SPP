using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class BookViewer
    {
        private IBookManager bookManager;
        private IBDManager reader;

        public FontOfText fontOfText { get; set; }

        public BookViewer(IBookManager bookManager, IBDManager reader)
        {
            this.bookManager = bookManager;
            this.reader = reader;
        }

        public string[] CreateBooksViewing()
        {
            return bookManager.CreateListOfBooks(reader);
        }
    }
}
