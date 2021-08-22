using AutoMapper;
using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biz.Models
{
    [AutoMap(typeof(Book))]
    public class BookDTO
    {
        public string Name { get; set; }
        public DateTime FinishedDate { get; set; }
        public DateTime StartedDate { get; set; }
        public string Author { get; set; }
    
    }
}
