using MapConverter.Models.Enums;

namespace MapConverter.Models;

public class Notes
{
    public double Time { get; set; }
    
    // LineIndex
    public Lane Lane { get; set; }
    
    // LineLayer
    public Row Row { get; set; }
    
    // Type
    public Color Color { get; set; }
    
    public int CutDirection { get; set; }
}