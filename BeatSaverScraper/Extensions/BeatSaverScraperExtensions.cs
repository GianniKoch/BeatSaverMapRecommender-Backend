using BeatSaverScraper.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BeatSaverScraper.Extensions;

public static class BeatSaverScraperExtensions
{
    public static void AddBeatSaverScraper(this IServiceCollection services)
    {
        services.AddSingleton<BeatSaverApiService>();
        services.AddSingleton<BeatSaverScraperService>();
    }
}