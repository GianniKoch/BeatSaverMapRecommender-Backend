using BeatSaverScraper;

namespace Scraper;

public class Constants : ConstantsBeatSaverScraper
{
    public override string Name { get; }
    public override Version Version { get; }

    public Constants()
    {
        Name = "BeatSaverScraper";
        Version = typeof(Constants).Assembly.GetName().Version!;
    }
}