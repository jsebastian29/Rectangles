namespace Rectangles.Models;

public class Rectangle
{
    public Coordinates BottomLeftCorner { get; set; }
    public Coordinates TopRightCorner { get; set; }
    public Coordinates TopLeftCorner { get; set; }
    public Coordinates BottomRightCorner { get; set; }    

    public Rectangle()
    {
        BottomLeftCorner = new();
        TopRightCorner = new();
        TopLeftCorner = new();
        BottomRightCorner = new();
    }
}