using BeatSaverScraper.Extensions;
using BeatSaverScraper.Interfaces;
using MapConverter.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scraper;
using Scraper.Jobs;

var host = Host.CreateDefaultBuilder()
    .ConfigureServices(sc =>
    {
        sc.AddSingleton<Constants>();
        sc.AddSingleton<IConstantsBeatSaverScraper>(provider => provider.GetRequiredService<Constants>());
        sc.AddBeatSaverScraper();
        // sc.AddMapConverter();
    })
    .Build();

var ss = ActivatorUtilities.CreateInstance<ScraperJob>(host.Services);
// var ss = ActivatorUtilities.CreateInstance<MapConverterJob>(host.Services);
await ss.RunAsync();