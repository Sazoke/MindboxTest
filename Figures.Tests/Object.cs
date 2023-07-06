using Figure.Core.Common.Extensions;
using Xunit;

namespace Figures.Tests;

public class Object
{
    [Fact]
    public void WrongObject()
    {
        object obj = new List<int>();
        var isSuccess = obj.TryGetSquare(out var result);
        Assert.False(isSuccess);
    }

    [Fact]
    public void CorrectObject()
    {
        object obj = new Figure.Core.Models.Circle(10);
        var isSuccess = obj.TryGetSquare(out var result);
        Assert.True(isSuccess);
    }
}