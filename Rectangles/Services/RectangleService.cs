namespace Rectangles.Services;

using Rectangles.Models;

public class RectangleService
{
    /// <summary>
    /// Checks if rectangles have intersection
    /// </summary>
    public string RectangleOperations(Rectangle rectangle1, Rectangle rectangle2)
    {
        if (IsRectangleWithoutArea(rectangle1, rectangle2))
            return "Rectangle without area.";

        var contaiment = Containment(rectangle1, rectangle2);
        var intersection = Intersection(rectangle1, rectangle2);

        if (!string.IsNullOrWhiteSpace(contaiment))
            return contaiment;

        if (string.IsNullOrWhiteSpace(contaiment) && intersection)
            return "The Rectangles have intersection.";
        if (string.IsNullOrWhiteSpace(contaiment) && !intersection)
            return "The Rectangles are adjacents.";

        return string.Empty;
    }

    /// <summary>
    /// Checks if rectangles have intersection
    /// </summary>
    private bool Intersection(Rectangle rectangle1, Rectangle rectangle2)
    {
        if (rectangle1.BottomLeftCorner.X < rectangle2.TopRightCorner.X && 
            rectangle2.BottomLeftCorner.X < rectangle1.TopRightCorner.X &&
            rectangle1.BottomLeftCorner.Y < rectangle2.TopRightCorner.Y &&
            rectangle2.BottomLeftCorner.Y < rectangle1.TopRightCorner.Y)
            return true;

        return false;
    }

    /// <summary>
    /// Checks if one rectangle is wholly contained within another rectangle.
    /// </summary>
    private string Containment(Rectangle rectangle1, Rectangle rectangle2)
    {
        if (rectangle1.BottomLeftCorner.X < rectangle2.BottomLeftCorner.X &&
        rectangle2.TopRightCorner.X < rectangle1.TopRightCorner.X &&
        rectangle1.BottomLeftCorner.Y < rectangle2.BottomLeftCorner.Y &&
        rectangle2.TopRightCorner.Y < rectangle1.TopRightCorner.Y)
            return "Rectangle 2 is contained inside Rectangle 1.";
            
        if (rectangle2.BottomLeftCorner.X < rectangle1.BottomLeftCorner.X &&
        rectangle1.TopRightCorner.X < rectangle2.TopRightCorner.X &&
        rectangle2.BottomLeftCorner.Y < rectangle1.BottomLeftCorner.Y &&
        rectangle1.TopRightCorner.Y < rectangle2.TopRightCorner.Y)
            return "Rectangle 1 is contained inside Rectangle 2.";

        return string.Empty;
    }
    
    /// <summary>
    /// Checks if one there's a rectangle without area.
    /// </summary>
    private bool IsRectangleWithoutArea(Rectangle rectangle1, Rectangle rectangle2)
    {
        if (rectangle1.BottomLeftCorner.X == rectangle1.TopRightCorner.X ||
            rectangle1.BottomLeftCorner.X == rectangle1.TopRightCorner.Y ||
            rectangle2.BottomLeftCorner.X == rectangle2.TopRightCorner.X ||
            rectangle2.BottomLeftCorner.X == rectangle2.TopRightCorner.Y)
            return true;

        return false;
    }
}