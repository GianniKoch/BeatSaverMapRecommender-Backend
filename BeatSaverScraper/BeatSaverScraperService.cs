using BeatSaverScraper.Extensions;
using BeatSaverScraper.Models;
using BeatSaverScraper.Services;

namespace BeatSaverScraper;

public class BeatSaverScraperService
{
    private readonly BeatSaverApiService _beatSaverApiService;

    public BeatSaverScraperService(BeatSaverApiService beatSaverApiService)
    {
        _beatSaverApiService = beatSaverApiService;
    }

    public async Task<ICollection<ScraperDifficulty>> ScrapeAllAsync()
    {
        var beatMaps = await _beatSaverApiService.GetLatestBeatMapsAsync();
        return beatMaps.SelectMany(bm => bm.ToScraperDifficulties()).ToList();
    }
}