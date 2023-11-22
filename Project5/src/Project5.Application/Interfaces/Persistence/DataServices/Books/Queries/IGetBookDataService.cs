using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Project5.Domain.Entities;

namespace Project5.Application.Interfaces.Persistence.DataServices.Books.Queries
{
    public interface IGetBooksDataService
    {
        Task<IEnumerable<Book>> ExecuteAsync();
    }
}
