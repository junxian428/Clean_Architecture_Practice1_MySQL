using System.Diagnostics.CodeAnalysis;
using Project5.Api.Extensions;
using Project5.Application.Endpoints.Books.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project5.Application.Endpoints.Books.Commands;

namespace Project5.Api.Controllers
{
    [ExcludeFromCodeCoverage]
    [ApiController]
    [Route("api/v{version:apiVersion}/books")]
    [ApiVersion("1.0")]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetBooksAsync([FromQuery] BookQuery request) =>
            (await _mediator.Send(request)).ToActionResult();

        [HttpPost]
        public async Task<ActionResult> AddBookAsync([FromBody] AddBookCommand command) =>
            (await _mediator.Send(command)).ToActionResult();
    }
}
