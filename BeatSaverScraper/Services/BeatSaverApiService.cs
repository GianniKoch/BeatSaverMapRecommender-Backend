using System.Collections.ObjectModel;
using BeatSaverScraper.Interfaces;
using BeatSaverSharp;
using BeatSaverSharp.Models;
using BeatSaverSharp.Models.Pages;

namespace BeatSaverScraper.Services;

public class BeatSaverApiService
{
    private readonly BeatSaver _beatSaverClient;

    public BeatSaverApiService(IConstantsBeatSaverScraper constants)
    {
        var beatSaverClientOptions = new BeatSaverOptions(constants.Name, constants.Version)
        {
            Cache = true,
            Timeout = TimeSpan.FromSeconds(10)
        };
        _beatSaverClient = new BeatSaver(beatSaverClientOptions);
    }

    public async Task<ICollection<Beatmap>> GetLatestBeatMapsAsync(CancellationToken cancellationToken = default)
    {
        var page = await _beatSaverClient.LatestBeatmaps(null, cancellationToken);
        if (page == null) return new Collection<Beatmap>();
        return await GetMapsFromPages(page, cancellationToken);
    }

    private static async Task<ICollection<Beatmap>> GetMapsFromPages(Page? page, CancellationToken cancellationToken)
    {
        var beatMaps = new List<Beatmap>();

        while (page != null)
        {
            beatMaps.AddRange(page.Beatmaps);
            page = await page.Next(cancellationToken);
            Thread.Sleep(50);
        }

        return beatMaps;
    }
}