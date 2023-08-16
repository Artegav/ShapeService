namespace ShapeService;

public class Circle : Shape
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    private double Radius { get; }

    public override double GetArea()
    {
        return (Radius * Radius * Math.PI);
    }
}