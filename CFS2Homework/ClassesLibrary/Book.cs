using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Book
    {
        //fields
        private string _title;
        private string _author;
        private int _numberOfPages;

        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        //fully q ctor
        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public Book() { }

        public override string ToString()
        {
            return string.Format("\nTitle: {0}\nAuthor: {1}\nNumber of pages: {2}", Title, Author, NumberOfPages);
        }

    }//end class
}// end Namespace
