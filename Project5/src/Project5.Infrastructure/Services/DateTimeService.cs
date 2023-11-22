using System.Diagnostics.CodeAnalysis;
using Project5.Application.Interfaces.Services;

namespace Project5.Infrastructure.Services;

[ExcludeFromCodeCoverage]
public class DateTimeService : IDateTimeService
{
    public DateTime UtcNow => DateTime.UtcNow;
}
