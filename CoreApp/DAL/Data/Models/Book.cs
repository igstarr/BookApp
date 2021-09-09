using CoreApp.DAL.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DAL.Data.Models
{
    public class Book
    {
        //public, parameterless constructor 
        private Book() { }
        public int Id { get; private set; }
        [Required]
        public string Name { get; private set; }

        public string CoverImageTitle { get; private set; }
        public byte[] CoverImageData { get; private set; }

        //Relationships

        private HashSet<BookAuthor> _authorsLink;
        public IReadOnlyCollection<BookAuthor> AuthorsLink => _authorsLink?.ToList();

        public static Book CreateBook(string name, ICollection<Author> authors, string coverImageTitle, byte[] coverImageData)
        {

            var book = new Book()
            {
                Name = name,
                CoverImageTitle = coverImageTitle,
                CoverImageData = coverImageData
            };
            byte order = 0;
            book._authorsLink = new HashSet<BookAuthor>(
                authors.Select(a =>
                    new BookAuthor(book, a, order++)));

            return book;
        }
        public static Book CreateBook(string name, string author, string coverImageTitle, byte[] coverImageData)
        {

            var book = new Book()
            {
                Name = name,
                CoverImageTitle = coverImageTitle,
                CoverImageData = coverImageData
            };
            book._authorsLink = new HashSet<BookAuthor> { new BookAuthor(book, Author.CreateAuthor(author), 0) };

            return book;
        }
    }


}
