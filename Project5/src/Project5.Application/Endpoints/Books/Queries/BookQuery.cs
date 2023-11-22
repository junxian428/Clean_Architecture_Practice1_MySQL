using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;


using Project5.Application.Models;

namespace Project5.Application.Endpoints.Books.Queries;

public class BookQuery : IRequest<EndpointResult<IEnumerable<BookViewModel>>>
{

}

