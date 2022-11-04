using Rectangles.Models;

namespace Rectangles.Tests.Fakes;

public class RectanglesWithoutAreaFake
{
    /// <summary>
    /// Fake data for testing rectangles without area
    /// </summary>
    public static IEnumerable<object[]> Data => new List<object[]>
    {
        new object[]
        {
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 1, Y = 1 },
                TopRightCorner = new Coordinates() { X = 1, Y = 3 }
            },
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 0, Y = 0 },
                TopRightCorner = new Coordinates() { X = 2, Y = 2 }
            }
        },
        new object[]
        {
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 1, Y = 1 },
                TopRightCorner = new Coordinates() { X = 3, Y = 3 }
            },
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 0, Y = 0 },
                TopRightCorner = new Coordinates() { X = 2, Y = 0 }
            }
        }
    };
}