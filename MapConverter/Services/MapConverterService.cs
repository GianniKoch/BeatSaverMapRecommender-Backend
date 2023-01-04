using System.Text.Json;
using MapConverter.Models;

namespace MapConverter.Services;

public class MapConverterService
{
    public async Task<Map?> LoadToMap(string filePath)
    {
        var inputs = await File.ReadAllTextAsync(filePath);
        return JsonSerializer.Deserialize<Map>(inputs);
    }
}