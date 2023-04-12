using System.Collections;
using BeatSaverScraper.Models;
using BeatSaverScraper.Models.Scraper;
using BeatSaverSharp.Models;

namespace BeatSaverScraper.Extensions;

public static class BeatMapExtensions
{
    public static IEnumerable<ScraperDifficulty> ToScraperDifficulties(this Beatmap beatMap)
    {
        var difficulties = beatMap.LatestVersion.Difficulties;
        return difficulties.Select(d => d.ToScraperDifficulty(beatMap));
    }

    private static ScraperDifficulty ToScraperDifficulty(this BeatmapDifficulty beatMapDifficulty, Beatmap beatMap)
    {
        return new ScraperDifficulty
        {
            MapInfo = new MapInfo
            {
                BeatMapId = beatMap.ID,
                MapName = beatMap.Name,
                CoverUrl = beatMap.LatestVersion.CoverURL,
                UploaderName = beatMap.Uploader.Name,
                Duration = beatMap.Metadata.Duration,
                Bpm = beatMap.Metadata.BPM,
                IsRanked = beatMap.Ranked,
                IsCurated = beatMap.BeatmapCurator != null,
                Tags = beatMap.Tags == null ? string.Empty : string.Join(";", beatMap.Tags),
                CommunityRating = beatMap.Stats.Score,
            },
            DifficultyInfo = new DifficultyInfo
            {
                Bombs = beatMapDifficulty.Bombs,
                Characteristic = (int)beatMapDifficulty.Characteristic,
                HasChroma = beatMapDifficulty.Chroma,
                HasCinema = beatMapDifficulty.Cinema,
                Difficulty = (int)beatMapDifficulty.Difficulty,
                Events = beatMapDifficulty.Events,
                HasMappingExtensions = beatMapDifficulty.MappingExtensions,
                HasNoodleExtensions = beatMapDifficulty.NoodleExtensions,
                Njs = beatMapDifficulty.NJS,
                Notes = beatMapDifficulty.Notes,
                Nps = beatMapDifficulty.NPS,
                Obstacles = beatMapDifficulty.Obstacles,
                Offset = beatMapDifficulty.Offset,
                Stars = beatMapDifficulty.Stars ?? 0,
                Errors = beatMapDifficulty.Parity.Errors,
                Resets = beatMapDifficulty.Parity.Resets,
                Warns = beatMapDifficulty.Parity.Warns
            }
        };
    }
}