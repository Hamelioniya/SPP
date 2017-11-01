using IOCForLibrary;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class BookLibrary : Form
    {
        private int numOfBook;

        public BookLibrary()
        {
            InitializeComponent();
            IoC.Register<FontOfText, StandartFont>();
            IoC.RegisterSingleton<IBDManager, FileReader>();
        }

        private void ShowAllBooksBtn_Click(object sender, EventArgs e)
        {
            BackPageBtn.Visible = false;
            NextPageBtn.Visible = false;
            booksTextBox.Text = "";

            IoC.Register<IBookManager, BookAllManager>();
            IoC.Register<BookViewer, BookViewer>();

            BookViewer bookViewer = IoC.Resolve<BookViewer>();

            booksTextBox.Font = bookViewer.fontOfText.textFont;
            booksTextBox.ForeColor = bookViewer.fontOfText.textColor;

            string[] books = bookViewer.CreateBooksViewing();

            if (books.Length > 1)
                booksTextBox.Text += "1.\n" + books[0];
            else
                booksTextBox.Text += books[0];
            for(int i = 1; i < books.Length; i++)
            {
                booksTextBox.Text += "\n"+(i+1).ToString() + "." + books[i];
            }
        }

        private void ShowPageOfBooksBtn_Click(object sender, EventArgs e)
        {
            BackPageBtn.Visible = true;
            NextPageBtn.Visible = true;
            booksTextBox.Text = "";

            IoC.Register<BookPageManager, BookPageManager>();
            BookPageManager bookPageManager = IoC.Resolve<BookPageManager>();
            bookPageManager.numOfPage = numOfBook;

            IoC.Register<IBookManager, BookPageManager>(bookPageManager);
            IoC.Register<BookViewer, BookViewer>();

            BookViewer bookViewer = IoC.Resolve<BookViewer>();

            string[] books = bookViewer.CreateBooksViewing();
            foreach (string book in books)
                booksTextBox.Text += book;
            numOfBook = bookPageManager.numOfPage;
        }

        private void BackPageBtn_Click(object sender, EventArgs e)
        {
            numOfBook--;
            ShowPageOfBooksBtn_Click(sender, e);
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            numOfBook++;
            ShowPageOfBooksBtn_Click(sender, e);
        }

        private void changeTextStyleBtn_Click(object sender, EventArgs e)
        {
            IoC.Register<FontOfText, UserStyle>();
        }
    }
}
