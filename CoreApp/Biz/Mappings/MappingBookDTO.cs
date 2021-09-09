//using AutoMapper;
using AutoMapper;
using Biz.Models;
using DAL.Data.Models;
using GenericServices.Configuration;
using System;
using System.Linq;

namespace Biz.Mappings
{

    class BookDTOConfig : PerDtoConfig<BookDTO, Book>
    {
        public override Action<IMappingExpression<Book, BookDTO>> AlterReadMapping
        {
            get
            {
                return cfg => cfg
                .ForMember(x => x.AuthorName, y => y.MapFrom(p => String.Join(", ",
                 p.AuthorsLink.Select(x => x.Author.Name))));
            }
        }
    }
    //    public class MappingBookDTO : Profile
    //    {
    //        public MappingBookDTO()
    //        {
    //            CreateMap<Book, Models.BookDTO>()
    //                .ForMember(p => p.Author,
    //                    m => m.MapFrom(s => string.Join(", ",
    //                    s.AuthorsLink.Select(x => x.Author.Name))));
    //        }
    //    }
}
