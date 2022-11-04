namespace Rectangles.Services;

using Rectangles.Models;
using System.Text;

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
            return GetIntersectionPoints(rectangle1, rectangle2);
        
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
    /// Checks if there's a rectangle without area.
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

    /// <summary>
    /// Gets the new rectangle created by the intersection.
    /// </summary>
    private string GetIntersectionPoints(Rectangle rectangle1, Rectangle rectangle2)
    {
        var intersectionRectangle = new Rectangle()
        {
            BottomLeftCorner = new Coordinates()
            {
                X = Math.Max(rectangle1.BottomLeftCorner.X, rectangle2.BottomLeftCorner.X),
                Y = Math.Max(rectangle1.BottomLeftCorner.Y, rectangle2.BottomLeftCorner.Y)
            },
            TopRightCorner = new Coordinates()
            {
                X = Math.Min(rectangle1.TopRightCorner.X, rectangle2.TopRightCorner.X),
                Y = Math.Min(rectangle1.TopRightCorner.Y, rectangle2.TopRightCorner.Y)
            },
            TopLeftCorner = new Coordinates()
            {
                X = Math.Max(rectangle1.BottomLeftCorner.X, rectangle2.BottomLeftCorner.X),
                Y = Math.Min(rectangle1.TopRightCorner.Y, rectangle2.TopRightCorner.Y)
            },
            BottomRightCorner = new Coordinates()
            {
                X = Math.Min(rectangle1.TopRightCorner.X, rectangle2.TopRightCorner.X),
                Y = Math.Max(rectangle1.BottomLeftCorner.Y, rectangle2.BottomLeftCorner.Y)
            },            
        };

        var result = new StringBuilder("The Rectangles have intersection in these points:\n");
        result.AppendLine($"({intersectionRectangle.BottomLeftCorner.X},{intersectionRectangle.BottomLeftCorner.Y})");
        result.AppendLine($"({intersectionRectangle.TopLeftCorner.X},{intersectionRectangle.TopLeftCorner.Y})");
        result.AppendLine($"({intersectionRectangle.TopRightCorner.X},{intersectionRectangle.TopRightCorner.Y})");
        result.AppendLine($"({intersectionRectangle.BottomRightCorner.X},{intersectionRectangle.BottomRightCorner.Y})");

        return result.ToString();
    }    
}