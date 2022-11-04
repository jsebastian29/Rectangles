using Rectangles.Models;
using Rectangles.Services;
using Rectangles.Tests.Fakes;
using System.Text;
using Xunit;

namespace Rectangles.Tests;

public class RectangleServiceTests
{
    private readonly RectangleService _service;

    public RectangleServiceTests()
    {
        _service = new RectangleService();
    }

    [Theory]
    [MemberData(nameof(RectanglesWithoutAreaFake.Data), MemberType=typeof(RectanglesWithoutAreaFake))]
    public void RectangleOperations_WhenARectangleWithoutArea_ShouldReturn_NoArea(Rectangle rectangle1,
        Rectangle rectangle2)
    {
        // Act
        var result = _service.RectangleOperations(rectangle1, rectangle2);

        // Assert
        Assert.Equal("Rectangle without area.", result);
    }

    [Theory]
    [MemberData(nameof(RectanglesContainmentFake.FirstCaseData), MemberType=typeof(RectanglesContainmentFake))]
    public void RectangleOperations_WhenRectangle1IsContainedInRectangle2_ShouldReturn_Containment(Rectangle rectangle1,
        Rectangle rectangle2)
    {
        // Act
        var result = _service.RectangleOperations(rectangle1, rectangle2);

        // Assert
        Assert.Equal("Rectangle 1 is contained inside Rectangle 2.", result);
    }

    [Theory]
    [MemberData(nameof(RectanglesContainmentFake.SecondCaseData), MemberType=typeof(RectanglesContainmentFake))]
    public void RectangleOperations_WhenRectangle2IsContainedInRectangle1_ShouldReturn_Containment(Rectangle rectangle1,
        Rectangle rectangle2)
    {
        // Act
        var result = _service.RectangleOperations(rectangle1, rectangle2);

        // Assert
        Assert.Equal("Rectangle 2 is contained inside Rectangle 1.", result);
    }

    [Theory]
    [MemberData(nameof(RectanglesAdjacentsFake.Data), MemberType=typeof(RectanglesAdjacentsFake))]
    public void RectangleOperations_WhenRectangles_AreAdjacent_ShouldReturn_Adjancency(Rectangle rectangle1,
        Rectangle rectangle2)
    {
        // Act
        var result = _service.RectangleOperations(rectangle1, rectangle2);

        // Assert
        Assert.Equal("The Rectangles are adjacents.", result);
    }

    [Theory]
    [MemberData(nameof(RectanglesIntersectionFake.FirstCaseData), MemberType=typeof(RectanglesIntersectionFake))]
    public void RectangleOperations_WhenRectangles_HasIntersection_ShouldReturn_Intersection_FirstCase(Rectangle rectangle1,
        Rectangle rectangle2)
    {
        // Act
        var result = _service.RectangleOperations(rectangle1, rectangle2);

        var expectedResult = new StringBuilder("The Rectangles have intersection in these points:\n");
        expectedResult.AppendLine("(3,3)");
        expectedResult.AppendLine("(3,4)");
        expectedResult.AppendLine("(6,4)");
        expectedResult.AppendLine("(6,3)");

        // Assert
        Assert.Equal(expectedResult.ToString(), result);
    }

    [Theory]
    [MemberData(nameof(RectanglesIntersectionFake.SecondCaseData), MemberType=typeof(RectanglesIntersectionFake))]
    public void RectangleOperations_WhenRectangles_HasIntersection_ShouldReturn_Intersection_SecondCase(Rectangle rectangle1,
        Rectangle rectangle2)
    {
        // Act
        var result = _service.RectangleOperations(rectangle1, rectangle2);

        var expectedResult = new StringBuilder("The Rectangles have intersection in these points:\n");
        expectedResult.AppendLine("(3,5)");
        expectedResult.AppendLine("(3,6)");
        expectedResult.AppendLine("(6,6)");
        expectedResult.AppendLine("(6,5)");

        // Assert
        Assert.Equal(expectedResult.ToString(), result);
    }    
}