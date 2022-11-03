using Rectangles.Models;
using Rectangles.Services;
using Rectangles.Tests.Fakes;

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
}