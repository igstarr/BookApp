using Biz.Logic;
using Biz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biz.Interface
{
    public interface IBookService
    {
        IQueryable<BookDTO> GetBooks(SortFilterPageOptions options);
        Task<bool> SeedBooks();
    }
}
