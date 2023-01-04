using System.Text.Json.Serialization;

namespace MapConverter.Models;

public class Map
{
    [JsonPropertyName("_notes")]
    public List<Notes> Notes { get; set; }

    [JsonPropertyName("_obstacles")]
    public List<Obstacle> Obstacles { get; set; }
}