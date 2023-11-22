using Project5.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Project5.Application.Interfaces.Persistence;

public interface IApplicationDbContext
{
    DbSet<Person> People { get; set; }

    DbSet<Book> Books { get; set; }


    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
