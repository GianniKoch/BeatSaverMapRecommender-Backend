using System.Globalization;
using BeatSaverScraper;
using BeatSaverScraper.Models;
using CsvHelper;
using Scraper.Interfaces;

namespace Scraper;

public class ScraperRunnable : IRunnable
{
    private readonly BeatSaverScraperService _beatSaverScraperService;

    public ScraperRunnable(BeatSaverScraperService beatSaverScraperService)
    {
        _beatSaverScraperService = beatSaverScraperService;
    }

    public async Task RunAsync()
    {
        var songs = await _beatSaverScraperService.ScrapeAllAsync();
        var scraperDifficulties = songs.ToList();
        Console.WriteLine(scraperDifficulties.Count);
        var writer = new StreamWriter("beatsaversongs.csv");
        var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteHeader<ScraperDifficulty>();
        await csv.NextRecordAsync();
        foreach (var record in scraperDifficulties)
        {
            csv.WriteRecord(record);
            await csv.NextRecordAsync();
        }
        await writer.FlushAsync();
    }
}