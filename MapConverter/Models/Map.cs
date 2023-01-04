using MapConverter.Models.Enums;

namespace MapConverter.Models;

public class Map
{
    public List<Notes> Notes { get; set; }

    public List<Obstacle> Obstacles { get; set; }
}