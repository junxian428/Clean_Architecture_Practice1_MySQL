using System.Threading;
using System.Threading.Tasks;
using Project5.Domain.Entities;

namespace Project5.Application.Interfaces.Persistence.DataServices.Books.Commands
{
    public interface IAddBookDataService
    {
        Task<Book> ExecuteAsync(Book book, CancellationToken cancellationToken = default);
    }
}
