using MapConverter.Models.Enums;

namespace MapConverter.Models;

public class MapSection
{
    public List<Notes> Notes { get; set; }

    public List<Obstacle> Obstacles { get; set; }
    
    public Dictionary<Tag, float> TagValues { get; set; }
}