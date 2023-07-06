using Figure.Core.Abstractions;

namespace Figure.Core.Models;

public class Circle : IFigure
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; }

    public bool IsValid() => Radius >= 0;

    public double GetSquare() => Math.PI * Math.Pow(Radius, 2);
}