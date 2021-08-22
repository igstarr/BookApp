using AutoMapper;
using AutoMapper.QueryableExtensions;
using Biz.Interface;
using Biz.Models;
using CoreApp.DAL.Data;
using DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biz.Logic
{
    public class Books : IBooks
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public Books(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public Books(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<BookDTO>> GetBooks()
        {
            return await _mapper.ProjectTo<BookDTO>(
                _context.Books
                .AsNoTracking()
                .Include(book => book.AuthorsLink)
                    .ThenInclude(bookAuthor => bookAuthor.Author)
                ).ToListAsync();
        }
    }
}
