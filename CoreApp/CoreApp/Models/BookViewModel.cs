using AutoMapper;
using Biz.Logic;
using Biz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class BookViewModelList
    {
        public BookViewModelList(SortFilterPageOptions sortFilterPageData, IEnumerable<BookViewModel> booksList)
        {
            SortFilterPageData = sortFilterPageData;
            BooksList = booksList;
        }

        public SortFilterPageOptions SortFilterPageData { get; private set; }

        public IEnumerable<BookViewModel> BooksList { get; private set; }
    }
}
[AutoMap(typeof(BookDTO))]
public class BookViewModel
{
    public string Name { get; set; }
    public DateTime FinishedDate { get; set; }
    public DateTime StartedDate { get; set; }
    public string AuthorName { get; set; }
    public string CoverImageTitle { get; set; }
    public byte[] CoverImageData { get; set; }

    public string displayImage { get; set; }
}

