using Figure.Core.Common.Extensions;
using Xunit;

namespace Figures.Tests;

public class Triangle
{
    [Fact]
    public void FalseIfNotCorrect()
    {
        object circle = new Figure.Core.Models.Triangle(5, 2, 2);
        var isSuccess = circle.TryGetSquare(out var result);
        Assert.False(isSuccess);
    }
    
    [Fact]
    public void CorrectRectangularTriangle()
    {
        object circle = new Figure.Core.Models.Triangle(3, 4, 5);
        var isSuccess = circle.TryGetSquare(out var result);
        Assert.True(isSuccess);
        Assert.Equal(6, result);
    }
    
    [Fact]
    public void CorrectTriangle()
    {
        object circle = new Figure.Core.Models.Triangle(7, 8, 9);
        var isSuccess = circle.TryGetSquare(out var result);
        Assert.True(isSuccess);
        Assert.True(result - 26.83 < 0.01);
    }
}