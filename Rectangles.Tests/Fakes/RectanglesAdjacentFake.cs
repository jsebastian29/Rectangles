using Rectangles.Models;

namespace Rectangles.Tests.Fakes;

public class RectanglesAdjacentsFake
{
    /// <summary>
    /// Fake data for testing adjacent rectangles
    /// </summary>
    public static IEnumerable<object[]> Data => new List<object[]>
    {
        new object[]
        {
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 2, Y = 3 },
                TopRightCorner = new Coordinates() { X = 7, Y = 7 }
            },

            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 7, Y = 4 },
                TopRightCorner = new Coordinates() { X = 11, Y = 6 }
            }
        },
        new object[]
        {
            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 2, Y = 3 },
                TopRightCorner = new Coordinates() { X = 7, Y = 7 }
            },

            new Rectangle()
            {
                BottomLeftCorner = new Coordinates() { X = 7, Y = 4 },
                TopRightCorner = new Coordinates() { X = 11, Y = 11 }
            }
        }
    };
}