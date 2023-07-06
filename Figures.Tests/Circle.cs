using Figure.Core.Common.Extensions;
using Xunit;

namespace Figures.Tests;

public class Circle
{
    [Fact]
    public void FalseIfNotCorrect()
    {
        object circle = new Figure.Core.Models.Circle(-100);
        var isSuccess = circle.TryGetSquare(out var result);
        Assert.False(isSuccess);
    }
    
    [Fact]
    public void TrueIfCorrect()
    {
        object circle = new Figure.Core.Models.Circle(10);
        var isSuccess = circle.TryGetSquare(out var result);
        Assert.True(isSuccess);
        Assert.Equal(100 * Math.PI, result);
    }
}