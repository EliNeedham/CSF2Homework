using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Library
    {
        private List<Book> _books;
        private string _libraryName;
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;

        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public Library() { }

        public override string ToString()
        {
            string booksNeeded = "";

            foreach (Book book in Books)
            {
                booksNeeded += book + "\n";
            }
                
            return string.Format("\n\nBooks: {0}\nLibrary Name: {1}\nStreet Address: {2}\nCity: {3}\nState: {4}\nZip: {5}\n",
                booksNeeded, 
                LibraryName, 
                StreetAddress, 
                City, 
                State, 
                Zip);
        }

    }//end class
}//end namespace
