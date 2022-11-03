namespace Rectangles.Models;

public class Rectangle
{
    public Coordinates BottomLeftCorner { get; set; }
    public Coordinates TopRightCorner { get; set; }

    public Rectangle()
    {
        BottomLeftCorner = new Coordinates();
        TopRightCorner = new Coordinates();
    }
}