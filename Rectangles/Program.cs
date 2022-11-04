// See https://aka.ms/new-console-template for more information
using Rectangles.Models;
using Rectangles.Services;

internal class Program
{
    private static RectangleService _service = new RectangleService();
    private static void Main(string[] args)
    {
        #region Test Cases
        // Intersection Case
        var rectangle1 = new Rectangle()
        {
            BottomLeftCorner = new Coordinates() { X = 2, Y = 1 },
            TopRightCorner = new Coordinates() { X = 6, Y = 4 }
        };

        var rectangle2 = new Rectangle()
        {
            BottomLeftCorner = new Coordinates() { X = 3, Y = 3 },
            TopRightCorner = new Coordinates() { X = 7, Y = 6 }
        };        

        // Containment Case
        // var rectangle1 = new Rectangle()
        // {
        //     BottomLeftCorner = new Coordinates() { X = 2, Y = 2 },
        //     TopRightCorner = new Coordinates() { X = 6, Y = 4 }
        // };

        // var rectangle2 = new Rectangle()
        // {
        //     BottomLeftCorner = new Coordinates() { X = 1, Y = 1 },
        //     TopRightCorner = new Coordinates() { X = 7, Y = 5 }
        // };

        // Adjacent Case
        // var rectangle1 = new Rectangle()
        // {
        //     BottomLeftCorner = new Coordinates() { X = 2, Y = 3 },
        //     TopRightCorner = new Coordinates() { X = 7, Y = 7 }
        // };

        // var rectangle2 = new Rectangle()
        // {
        //     BottomLeftCorner = new Coordinates() { X = 7, Y = 4 },
        //     TopRightCorner = new Coordinates() { X = 11, Y = 6 }
        // };     

        // No Area Case
        // var rectangle1 = new Rectangle()
        // {
        //     BottomLeftCorner = new Coordinates() { X = 1, Y = 1 },
        //     TopRightCorner = new Coordinates() { X = 1, Y = 3 }
        // };

        // var rectangle2 = new Rectangle()
        // {
        //     BottomLeftCorner = new Coordinates() { X = 0, Y = 0 },
        //     TopRightCorner = new Coordinates() { X = 2, Y = 2 }
        // };

        #endregion

        var result = _service.RectangleOperations(rectangle1, rectangle2);
        Console.WriteLine(result);
    }
}