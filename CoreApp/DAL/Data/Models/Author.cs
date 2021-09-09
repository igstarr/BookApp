using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Data.Models
{
    public class Author
    {
        //public, parameterless constructor 
        private Author() { }
        public int Id { get; private set; }
        [Required]
        public string Name { get; private set; }

        public ICollection<BookAuthor> BooksLink { get; set; }

        public static Author CreateAuthor(string name)
        {
            Author author = new Author()
            {
                Name = name,
            };
            return author;
        }
    }
}
