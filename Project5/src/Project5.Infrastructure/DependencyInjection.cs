using System.Text.RegularExpressions;
using Project5.Application.Interfaces.Persistence;
using Project5.Application.Interfaces.Services;
using Project5.Infrastructure.Persistence;
using Project5.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Project5.Infrastructure;

public static class DependencyInjection
{
    private static readonly Regex InterfacePattern = new Regex("I(?:.+)DataService", RegexOptions.Compiled);

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddDbContext<ApplicationDbContext>()
            .AddScoped<IApplicationDbContext, ApplicationDbContext>();

        (from c in typeof(Application.DependencyInjection).Assembly.GetTypes()
         where c.IsInterface && InterfacePattern.IsMatch(c.Name)
         from i in typeof(DependencyInjection).Assembly.GetTypes()
         where c.IsAssignableFrom(i)
         select new
         {
             Contract = c,
             Implementation = i
         }).ToList()
        .ForEach(x => services.AddScoped(x.Contract, x.Implementation));

        services.AddSingleton<IDateTimeService, DateTimeService>();
        services.AddScoped(typeof(ILoggerService<>), typeof(LoggerService<>));

        return services;
    }
}
