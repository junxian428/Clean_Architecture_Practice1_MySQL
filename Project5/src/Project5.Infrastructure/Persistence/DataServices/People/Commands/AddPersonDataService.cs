using Project5.Application.Interfaces.Persistence;
using Project5.Application.Interfaces.Persistence.DataServices.People.Commands;
using Project5.Domain.Entities;

namespace Project5.Infrastructure.Persistence.DataServices.People.Commands;

public class AddPersonDataService : IAddPersonDataService
{
    private readonly IApplicationDbContext _dbContext;

    public AddPersonDataService(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Person> ExecuteAsync(Person person, CancellationToken cancellationToken = default)
    {
        _dbContext.People.Add(person);

        await _dbContext.SaveChangesAsync(cancellationToken);
        return person;
    }
}
