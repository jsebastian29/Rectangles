using Rectangles.Models;

namespace Rectangles.Tests.Fakes;

public class RectanglesIntersectionFake
{
    /// <summary>
    /// Fake data for testing intersected rectangles
    /// </summary>
    public static IEnumerable<object[]> FirstCaseData => new List<object[]>
    {
        new object[]
        {
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 2, Y = 1 },
                TopRightCorner = new Coordinates() { X = 6, Y = 4 }
            },
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 3, Y = 3 },
                TopRightCorner = new Coordinates() { X = 7, Y = 6 }
            } 
        }
    };

    /// <summary>
    /// Fake data for testing intersected rectangles
    /// </summary>
    public static IEnumerable<object[]> SecondCaseData => new List<object[]>
    {
        new object[]
        {
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 2, Y = 5 },
                TopRightCorner = new Coordinates() { X = 8, Y = 8 }
            },
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 3, Y = 4 },
                TopRightCorner = new Coordinates() { X = 6, Y = 6 }
            } 
        }        
    };    
}