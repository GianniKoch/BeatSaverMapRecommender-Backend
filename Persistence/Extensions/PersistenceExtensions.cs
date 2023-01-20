using Persistence.Interfaces;
using Persistence.Repositories;

namespace Persistence.Extensions;
using Microsoft.Extensions.DependencyInjection;

public static class PersistenceExtensions
{
    public static void AddPersistence(this IServiceCollection services)
    {
        services.AddSingleton<ITagValueResponseRepository, InMemoryTagValueResponseRepository>();
    }
}