using BeatSaverScraper;

namespace Backend_API;

public class Constants : ConstantsBeatSaverScraper
{
    public override string Name { get; }
    public override Version Version { get; }

    public Constants()
    {
        Name = "BeatSaverMapRecommenderBackendApi";
        Version = typeof(Constants).Assembly.GetName().Version!;
    }
}