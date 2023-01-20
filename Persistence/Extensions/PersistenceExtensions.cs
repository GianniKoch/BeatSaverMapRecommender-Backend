using Marten;
using Persistence.Interfaces;
using Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence.Extensions;

public static class PersistenceExtensions
{
    public static void AddPersistence(this IServiceCollection services, string? connectionString)
    {
        if (connectionString == null) throw new ArgumentNullException(nameof(connectionString));
        services.AddMarten(o =>
        {
            o.Connection(connectionString);
        });
        services.AddScoped<ITagValueResponseRepository, MartenTagValueResponseRepository>();
    }
}