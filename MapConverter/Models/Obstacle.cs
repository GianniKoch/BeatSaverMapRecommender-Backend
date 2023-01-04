using MapConverter.Models.Enums;

namespace MapConverter.Models;

public class Obstacle
{
    public double Time { get; set; }
    
    // Line Index
    public Lane Lane { get; set; }
    
    // Type
    public WallType WallType { get; set; }
    
    public double Duration { get; set; }
    
    public int Width { get; set; }
    
}