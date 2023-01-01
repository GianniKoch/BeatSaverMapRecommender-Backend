namespace BeatSaverScraper.Models.Scraper;

public class DifficultyInfo
{
    /// <summary>
    /// The amount of bombs in the difficulty.
    /// </summary>
    public required int Bombs { get; set; }

    /// <summary>
    /// What characteristic this difficulty is mapped in.
    /// </summary>
    public required int Characteristic { get; set; }

    /// <summary>
    /// Difficulty has Chroma.
    /// </summary>
    public required bool HasChroma { get; set; }

    /// <summary>
    /// Difficulty has Cinema.
    /// </summary>
    public required bool HasCinema { get; set; }

    /// <summary>
    /// Difficulty type.
    /// </summary>
    public required int Difficulty { get; set; }

    /// <summary>
    /// Amount of events in the difficulty.
    /// </summary>
    public required int Events { get; set; }

    /// <summary>
    /// Difficulty has mapping extensions.
    /// </summary>
    public required bool HasMappingExtensions { get; set; }

    /// <summary>
    /// Difficulty has Noodle Extensions.
    /// </summary>
    public required bool HasNoodleExtensions { get; set; }

    /// <summary>
    /// Note jump speed value of the difficulty.
    /// </summary>
    public required float Njs { get; set; }

    /// <summary>
    /// The note count of this difficulty.
    /// </summary>
    public required int Notes { get; set; }

    /// <summary>
    /// The notes per second value of this difficulty.
    /// </summary>
    public required double Nps { get; set; }

    /// <summary>
    /// The obstacle count of this difficulty.
    /// </summary>
    public required int Obstacles { get; set; }

    /// <summary>
    /// The offset value of this difficulty.
    /// </summary>
    public required float Offset { get; set; }

    /// <summary>
    /// The star difficulty value of this difficulty.
    /// </summary>
    public required float Stars { get; set; }

    /// <summary>
    /// The amount of errors in the difficulty.
    /// </summary>
    public required int Errors { get; set; }

    /// <summary>
    /// The amount of angle resets in the difficulty.
    /// </summary>
    public required int Resets { get; set; }

    /// <summary>
    /// The amount of warnings in the difficulty.
    /// </summary>
    public required int Warns { get; set; }
}