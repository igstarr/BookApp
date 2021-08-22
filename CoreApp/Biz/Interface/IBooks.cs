using Biz.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biz.Interface
{
    public interface IBooks
    {
        Task<List<BookDTO>> GetBooks();

    }
}
