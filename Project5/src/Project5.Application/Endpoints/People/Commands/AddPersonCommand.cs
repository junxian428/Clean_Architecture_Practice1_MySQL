using Project5.Application.Models;
using MediatR;

namespace Project5.Application.Endpoints.People.Commands;

public class AddPersonCommand : IRequest<EndpointResult<PersonViewModel>>
{
    public int? Id { get; init; }
    public string FirstName { get; init; } = "";
    public string LastName { get; init; } = "";
}
