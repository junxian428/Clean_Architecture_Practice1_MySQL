using Project5.Application.Interfaces.Persistence;
using Project5.Application.Interfaces.Persistence.DataServices.People.Queries;
using Project5.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Project5.Infrastructure.Persistence.DataServices.People.Queries;

public class GetPeopleDataService : IGetPeopleDataService
{
    private readonly IApplicationDbContext _dbContext;

    public GetPeopleDataService(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Person>> ExecuteAsync(bool includeInactive, CancellationToken cancellationToken = default)
    {
        return await _dbContext.People.Where(p => includeInactive || p.Active).ToListAsync(cancellationToken);
    }
}
