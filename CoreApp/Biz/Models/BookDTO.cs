using DAL.Data.Models;
using GenericServices;
using System;

namespace Biz.Models
{
    public class BookDTO : ILinkToEntity<Book>
    {
        public string Name { get; set; }
        public DateTime FinishedDate { get; set; }
        public DateTime StartedDate { get; set; }
        public string AuthorName { get; set; }
        public string CoverImageTitle { get; set; }
        public byte[] CoverImageData { get; set; }

    }
}
