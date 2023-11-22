using AutoMapper;
using Project5.Application.Interfaces;
using Project5.Application.Interfaces.Persistence.DataServices.Books.Commands;
using Project5.Application.Models;
using Project5.Application.Models.Enumerations;
using Project5.Domain.Entities;
using MediatR;

namespace Project5.Application.Endpoints.Books.Commands
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, EndpointResult<BookViewModel>>
    {
        private readonly IRequestValidator<AddBookCommand> _requestValidator;
        private readonly IAddBookDataService _addBookDataService;
        private readonly IMapper _mapper;

        public AddBookCommandHandler(
            IRequestValidator<AddBookCommand> requestValidator,
            IAddBookDataService addBookDataService,
            IMapper mapper
        )
        {
            _requestValidator = requestValidator;
            _addBookDataService = addBookDataService;
            _mapper = mapper;
        }

        public async Task<EndpointResult<BookViewModel>> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var validationErrors = _requestValidator.ValidateRequest(request);
            if (validationErrors.Count() > 0)
                return new EndpointResult<BookViewModel>(EndpointResultStatus.Invalid, validationErrors.ToArray());

            var book = await _addBookDataService.ExecuteAsync(_mapper.Map<Book>(request));
            return new EndpointResult<BookViewModel>(_mapper.Map<BookViewModel>(book));
        }
    }
}
