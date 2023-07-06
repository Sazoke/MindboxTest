using Figure.Core.Abstractions;

namespace Figure.Core.Common.Extensions;

public static class ObjectExtensions
{
    public static bool TryGetSquare(this object obj, out double square)
    {
        square = 0;
        var type = obj.GetType();
        var squareMethod = type.GetMethod(nameof(IFigure.GetSquare), Array.Empty<Type>());
        if (squareMethod is null || squareMethod.ReturnType != typeof(double))
            return false;
        var validMethod = type.GetMethod(nameof(IFigure.IsValid), Array.Empty<Type>());
        if (validMethod is not null && validMethod.Invoke(obj, parameters: Array.Empty<object?>()) is false)
            return false;
        square = (double)squareMethod.Invoke(obj, parameters: Array.Empty<object?>())!;
        return true;
    }
}