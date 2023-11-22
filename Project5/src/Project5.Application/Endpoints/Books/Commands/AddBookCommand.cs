using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Project5.Application.Endpoints.Books;
using Project5.Application.Models;

namespace Project5.Application.Endpoints.Books.Commands;

public class AddBookCommand : IRequest<EndpointResult<BookViewModel>>
{
    public int? Id { get; init; }
    public string Title { get; init; } = "";
    public string Author { get; init; } = "";
    public int Year { get; init; }

    // Additional properties for the add book operation
}



