using System;

class Triangle
{
    protected double sideA;
    protected double sideB;
    protected double sideC;

    public Triangle(double a, double b, double c)
    {
        SetSides(a, b, c);
    }

    public void SetSides(double a, double b, double c)
    {
        if (IsValidTriangle(a, b, c))
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }
        else
        {
            throw new ArgumentException("Неприпустимі значення сторін трикутника.");
        }
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && b + c > a && a + c > b;
    }

    public void CalculateAngles(out double angleA, out double angleB, out double angleC)
    {
        double cosA = (sideB * sideB + sideC * sideC - sideA * sideA) / (2 * sideB * sideC);
        double cosB = (sideA * sideA + sideC * sideC - sideB * sideB) / (2 * sideA * sideC);
        double cosC = (sideA * sideA + sideB * sideB - sideC * sideC) / (2 * sideA * sideB);

        angleA = Math.Acos(cosA) * (180.0 / Math.PI);
        angleB = Math.Acos(cosB) * (180.0 / Math.PI);
        angleC = Math.Acos(cosC) * (180.0 / Math.PI);
    }

    public double CalculatePerimeter()
    {
        return sideA + sideB + sideC;
    }
}

class RightAngled : Triangle
{
    private double area;

    public RightAngled(double a, double b) : base(a, b, Math.Sqrt(a * a + b * b))
    {
        CalculateArea();
    }

    public double Area
    {
        get { return area; }
    }

    private void CalculateArea()
    {
        area = 0.5 * sideA * sideB;
    }
}

class Program
{
    static void Main()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double angleA, angleB, angleC;
        triangle.CalculateAngles(out angleA, out angleB, out angleC);
        Console.WriteLine($"Angles of the triangle: {angleA}, {angleB}, {angleC}");
        Console.WriteLine($"Perimeter of the triangle: {triangle.CalculatePerimeter()}");

        RightAngled rightAngledTriangle = new RightAngled(3, 4);
        Console.WriteLine($"Area of the right-angled triangle: {rightAngledTriangle.Area}");
    }
}

