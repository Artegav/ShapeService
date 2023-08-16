namespace ShapeService;

public class Triangle : Shape
{
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    private double SideA { get; }

    private double SideB { get; }

    private double SideC { get; }
    
    public override double GetArea()
    {
        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
    
    public bool IsRightTriangle()
    {
        var sides = new double[] { SideA, SideB, SideC };
        Array.Sort(sides);
        return (sides[0] * sides[0]) + (sides[1] * sides[1]) == (sides[2] * sides[2]);
    }
}