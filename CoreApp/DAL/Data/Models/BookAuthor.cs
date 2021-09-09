using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Data.Models
{
    public class BookAuthor
    {
        //public, parameterless constructor 
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public byte Order { get; set; }

        //-----------------------------
        //Relationships

        public Book Book { get; set; }
        public Author Author { get; set; }

        private BookAuthor() { }
        internal BookAuthor(Book book, Author author, byte order)
        {
            Book = book;
            Author = author;
            Order = order;
        }
    }
}
