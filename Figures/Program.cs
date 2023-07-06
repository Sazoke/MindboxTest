// See https://aka.ms/new-console-template for more information

using Figure.Core.Common.Extensions;
using Figure.Core.Models;

var arr = new object[] { new Circle(10), new Triangle(3, 4, 5) };
foreach (var obj in arr)
    if (obj.TryGetSquare(out var square))
        Console.WriteLine(square);
