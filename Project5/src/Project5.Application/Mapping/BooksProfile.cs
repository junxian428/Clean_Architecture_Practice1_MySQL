using AutoMapper;
using Project5.Application.Endpoints.Books;
using Project5.Application.Endpoints.Books.Commands;
using Project5.Domain.Entities;

namespace Project5.Application.Mapping
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            CreateMap<Book, BookViewModel>()
                .ReverseMap();

            CreateMap<AddBookCommand, Book>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year));
                
        }
    }
}
