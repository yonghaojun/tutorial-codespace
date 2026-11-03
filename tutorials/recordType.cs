Point pt3 = new Point(1,1);
var pt4 = pt3 with { Y = 10 };
Console.WriteLine($"The two points are {pt3} and {pt4}");
double slopeResult = pt4.slope();
Console.WriteLine($"The slope of {pt4} is {slopeResult}");
public record struct Point(int X, int Y)
{
    public double slope() => (double)Y / (double)X;
}
