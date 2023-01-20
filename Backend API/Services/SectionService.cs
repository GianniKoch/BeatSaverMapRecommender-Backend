using Backend_API.Interfaces;
using BeatSaverSharp;
using BeatSaverSharp.Models;
using Persistence.Interfaces;
using Persistence.Models;

namespace Backend_API.Services;

public class SectionService : ISectionService
{
    private readonly BeatSaver _beatSaverClient;
    private readonly ITagValueResponseRepository _repository;

    public SectionService(ITagValueResponseRepository repository)
    {
        _repository = repository;
        var beatSaverClientOptions =
            new BeatSaverOptions("MapRecommender", typeof(Constants).Assembly.GetName().Version!)
            {
                Cache = true,
                Timeout = TimeSpan.FromSeconds(10)
            };
        _beatSaverClient = new BeatSaver(beatSaverClientOptions);
    }

    public async Task<Section> GetRandomSectionAsync()
    {
        Beatmap? map;
        BeatmapDifficulty? difficulty;
        do
        {
            var latestBeatPage = await _beatSaverClient.LatestBeatmaps();
            var latestBeatMap = latestBeatPage?.Beatmaps[0];
            if (latestBeatMap == null)
                throw new Exception();

            var randomId = GetNewRandomMapId(latestBeatMap.ID);
            map = await _beatSaverClient.Beatmap(randomId);
            difficulty = map?.LatestVersion.Difficulties.MaxBy(x => x.Difficulty);
        } while (map == null || difficulty is not { Seconds: > 30 });

        var startNote = new Random().Next(15, (int)(difficulty.Seconds - 15));

        return new Section
        {
            BeatMapId = map.ID,
            StartTime = startNote
        };
    }

    public async Task AddTagValues(TagValuesResponse response)
    {
        
        if (response.Tags == null) return;
        var sumTags = response.Tags.Sum(t => t.Value);
        if (sumTags == 0) return;
        // If the sum needs to be in between 0 and 1.
        // response.Tags = response.Tags.Select(t =>
        // {
        //     t.Value /= sumTags;
        //     return t;
        // }).ToList();
        await _repository.Save(response);
    }

    public async Task<IReadOnlyList<TagValuesResponse>> GetAllSections()
    {
        return await _repository.ReadAll();
    }


    private string GetNewRandomMapId(string id)
    {
        var decId = Convert.ToInt32(id, 16) + 1;
        var randomId = new Random().Next(1, decId);
        return Convert.ToString(randomId, 16);
    }
}