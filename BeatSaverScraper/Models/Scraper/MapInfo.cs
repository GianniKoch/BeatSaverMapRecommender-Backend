namespace BeatSaverScraper.Models.Scraper;

public class MapInfo
{
    /// <summary>
    /// BeatSaver id for this map.
    /// </summary>
    public required string BeatMapId { get; set; }

    /// <summary>
    /// Name of the BeatSaver uploader.
    /// </summary>
    public required string UploaderName { get; set; }

    /// <summary>
    /// The duration of the map.
    /// </summary>
    public required int Duration { get; set; }

    /// <summary>
    /// The bpm of the map.
    /// </summary>
    public required float Bpm { get; set; }

    /// <summary>
    /// Is this map ranked on ScoreSaber.
    /// </summary>
    public required bool IsRanked { get; set; }

    /// <summary>
    /// Is this map curated on BeastSaber.
    /// </summary>
    public required bool IsCurated { get; set; }

    /// <summary>
    /// All tags for this map.
    /// </summary>
    public required string Tags { get; set; }

    /// <summary>
    /// Community rating for this map on BeatSaver.
    /// </summary>
    public required float CommunityRating { get; set; }
}