using System.Text.Json.Serialization;
using MapConverter.Models.Enums;

namespace MapConverter.Models;

public class Notes
{
    [JsonPropertyName("_time")]
    public double Time { get; set; }
    
    [JsonPropertyName("_lineIndex")]
    public Lane Lane { get; set; }
    
    [JsonPropertyName("_lineLayer")]
    public Row Row { get; set; }
    
    [JsonPropertyName("_type")]
    public Color Color { get; set; }
    
    [JsonPropertyName("_cutDirection")]
    public Direction Direction { get; set; }
}