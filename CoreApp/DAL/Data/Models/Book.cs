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
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime FinishedDate { get; set; }
        public DateTime StartedDate { get; set; }

        //Relationships
        public ICollection<BookAuthor> AuthorsLink { get; set; }

    }


}
