using AutoMapper;
using Project5.Application.Interfaces.Persistence.DataServices.Books.Queries;
using Project5.Application.Models;
using MediatR;

namespace Project5.Application.Endpoints.Books.Queries
{
    public class GetBooksQueryHandler : IRequestHandler<BookQuery, EndpointResult<IEnumerable<BookViewModel>>>
    {
        private readonly IGetBooksDataService _getBooksDataService;
        private readonly IMapper _mapper;

        public GetBooksQueryHandler(IGetBooksDataService getBooksDataService, IMapper mapper)
        {
            _getBooksDataService = getBooksDataService;
            _mapper = mapper;
        }

        public async Task<EndpointResult<IEnumerable<BookViewModel>>> Handle(BookQuery request, CancellationToken cancellationToken = default)
        {
            var books = await _getBooksDataService.ExecuteAsync();

            return new EndpointResult<IEnumerable<BookViewModel>>(_mapper.Map<BookViewModel[]>(books));
        }
    }
}
