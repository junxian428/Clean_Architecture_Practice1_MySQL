using System.Threading;
using System.Threading.Tasks;
using Project5.Application.Interfaces.Persistence;
using Project5.Application.Interfaces.Persistence.DataServices.Books.Commands;
using Project5.Domain.Entities;

namespace Project5.Infrastructure.Persistence.DataServices.Books.Commands
{
    public class AddBookDataService : IAddBookDataService
    {
        private readonly IApplicationDbContext _dbContext;

        public AddBookDataService(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Book> ExecuteAsync(Book book, CancellationToken cancellationToken = default)
        {
            _dbContext.Books.Add(book);

            await _dbContext.SaveChangesAsync(cancellationToken);
            return book;
        }
    }
}
