using Figure.Core.Abstractions;

namespace Figure.Core.Models;

public class Triangle : IFigure
{
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double A { get; }
    
    public double B { get; }
    
    public double C { get; }

    public bool IsValid() => A >= 0 && B >= 0 && C >= 0 && A + B > C && A + C > B && B + C > A;

    public double GetSquare()
    {
        var arr = new List<double>() { A, B, C };
        var max = arr.Max();
        arr.Remove(max);
        var sum = arr.Aggregate((sum, x) => sum + Math.Pow(x, 2));
        if (Math.Abs(sum - Math.Pow(max, 2)) < double.Epsilon)
            return arr[0] * arr[1] / 2;
        var p = (A + B + C) / 2;
        return Math.Pow(p * (p - A) * (p - B) * (p - C), 0.5);
    }
}