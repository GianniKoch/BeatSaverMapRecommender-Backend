using BeatSaverScraper.Models.Scraper;

namespace BeatSaverScraper.Models;

public class ScraperDifficulty
{
    public required MapInfo MapInfo { get; set; }

    public required DifficultyInfo DifficultyInfo { get; set; }
}