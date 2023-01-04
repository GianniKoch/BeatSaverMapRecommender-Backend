using System.Text.Json.Serialization;
using MapConverter.Models.Enums;

namespace MapConverter.Models;

public class Obstacle
{
    [JsonPropertyName("_time")]
    public double Time { get; set; }
    
    [JsonPropertyName("_lineIndex")]
    public Lane Lane { get; set; }
    
    [JsonPropertyName("_type")]
    public WallType WallType { get; set; }
    
    [JsonPropertyName("_duration")]
    public double Duration { get; set; }
    
    [JsonPropertyName("_width")]
    public int Width { get; set; }
    
}