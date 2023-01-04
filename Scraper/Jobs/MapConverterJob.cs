using MapConverter.Services;
using Scraper.Interfaces;

namespace Scraper.Jobs;

public class MapConverterJob: IJob
{
    private readonly MapConverterService _mapConverterService;

    public MapConverterJob(MapConverterService mapConverterService)
    {
        _mapConverterService = mapConverterService;
    }

    public async Task RunAsync()
    {
        const string filePath = @"\ExpertStandard.dat";
        
        var map = await _mapConverterService.LoadToMap(filePath);

        Console.WriteLine(map.Notes.Count);
    }
}