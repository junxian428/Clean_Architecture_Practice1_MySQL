using Project5.Domain.Entities;

namespace Project5.Application.Interfaces.Persistence.DataServices.People.Queries;

public interface IGetPeopleDataService
{
    Task<IEnumerable<Person>> ExecuteAsync(bool includeInactive, CancellationToken cancellationToken = default);
}
