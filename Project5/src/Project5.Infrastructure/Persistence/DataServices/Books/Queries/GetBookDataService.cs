using Project5.Application.Interfaces.Persistence;
using Project5.Application.Interfaces.Persistence.DataServices.Books.Queries;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project5.Domain.Entities;

namespace Project5.Infrastructure.Persistence.DataServices.Books.Queries
{
    public class GetBooksDataService : IGetBooksDataService
    {
        private readonly IApplicationDbContext _dbContext;

        public GetBooksDataService(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Book>> ExecuteAsync()
        {
            return await _dbContext.Books.ToListAsync();
        }

    }
}
