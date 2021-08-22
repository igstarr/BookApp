using AutoMapper;
using Biz.Models;
using DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biz
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDTO>()
                .ForMember(p => p.Author,
                    m => m.MapFrom(s => string.Join(", ",
                    s.AuthorsLink.Select(x => x.Author.Name))));
        }
    }
}
