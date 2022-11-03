using Rectangles.Models;

namespace Rectangles.Tests.Fakes;

public class RectanglesContainmentFake
{
    /// <summary>
    /// Fake data for testing
    /// </summary>
    public static IEnumerable<object[]> FirstCaseData => new List<object[]>
    {
        new object[]
        {
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 2, Y = 2 },
                TopRightCorner = new Coordinates() { X = 6, Y = 4 }
            },
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 1, Y = 1 },
                TopRightCorner = new Coordinates() { X = 7, Y = 5 }
            },
        }
    };

    /// <summary>
    /// Fake data for testing
    /// </summary>
    public static IEnumerable<object[]> SecondCaseData => new List<object[]>
    {
        new object[]
        {
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 1, Y = 1 },
                TopRightCorner = new Coordinates() { X = 7, Y = 5 }
            },
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 6, Y = 2 },
                TopRightCorner = new Coordinates() { X = 2, Y = 4 }
            },
        }
    };
}