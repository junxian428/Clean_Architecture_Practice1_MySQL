using Project5.Domain.Entities;

namespace Project5.Application.Interfaces.Persistence.DataServices.People.Commands;

public interface IAddPersonDataService
{
    Task<Person> ExecuteAsync(Person person, CancellationToken cancellationToken = default);
}

