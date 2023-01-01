using BeatSaverScraper.Interfaces;

namespace BeatSaverScraper;

public abstract class ConstantsBeatSaverScraper : IConstantsBeatSaverScraper
{
    public abstract string Name { get; }
    public abstract Version Version { get; }
}