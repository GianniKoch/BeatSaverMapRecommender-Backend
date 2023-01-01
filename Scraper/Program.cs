using BeatSaverScraper.Extensions;
using BeatSaverScraper.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scraper;
using Scraper.Interfaces;

var host = Host.CreateDefaultBuilder()
    .ConfigureServices(sc =>
    {
        sc.AddSingleton<Constants>();
        sc.AddSingleton<IConstantsBeatSaverScraper>(provider => provider.GetRequiredService<Constants>());
        sc.AddBeatSaverScraper();
        sc.AddTransient<IRunnable, ScraperRunnable>();
    })
    .Build();

var ss = ActivatorUtilities.CreateInstance<ScraperRunnable>(host.Services);
await ss.RunAsync();