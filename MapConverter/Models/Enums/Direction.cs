namespace MapConverter.Models.Enums;

public enum Direction
{
    /* Side of the arrow
     * -------------
     * | 7 | 1 | 6 |
     * -------------
     * | 3 | 8 | 2 |
     * -------------
     * | 5 | 0 | 4 |
     * -------------
     */
    Bottom,
    Top,
    Right,
    Left,
    BottomRight,
    BottomLeft,
    TopRight,
    TopLeft,
    Dot
}