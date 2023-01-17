using System.Globalization;
using BeatSaverScraper;
using BeatSaverScraper.Models;
using BeatSaverScraper.Services;
using CsvHelper;
using Scraper.Interfaces;

namespace Scraper.Jobs;

public class ScraperJob : IJob
{
    private readonly BeatSaverScraperService _beatSaverScraperService;

    public ScraperJob(BeatSaverScraperService beatSaverScraperService)
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