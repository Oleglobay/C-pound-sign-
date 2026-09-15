using System;

class Rectangle
{
    private double a;  
    private double b;  

    public Rectangle(double sideA, double sideB)
    {
        SetSides(sideA, sideB);
    }

    private bool AreValidSides(double sideA, double sideB)
    {
        return sideA > 0 && sideB > 0;
    }

    public void SetSides(double sideA, double sideB)
    {
        if (AreValidSides(sideA, sideB))
        {
            a = sideA;
            b = sideB;
        }
        else
        {
            Console.WriteLine("Помилка: Недопустимі значення сторін прямокутника.");
        }
    }

    public (double, double) GetSides()
    {
        return (a, b);
    }

    public double CalculateArea()
    {
        return a * b;
    }

    public double CalculatePerimeter()
    {
        return 2 * (a + b);
    }

    public (double, double) CalculateDiagonals()
    {
        double diagonal1 = Math.Sqrt(a * a + b * b);
        double diagonal2 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        return (diagonal1, diagonal2);
    }

    public string DetermineRectangleType()
    {
        return a == b ? "Квадрат" : "Прямокутник";
    }

    public override bool Equals(object obj)
    {
        if (obj is Rectangle other)
        {
            return a == other.a && b == other.b;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(a, b);
    }
}

class Program
{
    static void Main()
    {
        Rectangle rectangle1 = new Rectangle(4, 6);
        Rectangle rectangle2 = new Rectangle(4, 6);

        Console.WriteLine($"Площа: {rectangle1.CalculateArea()}");
        Console.WriteLine($"Периметр: {rectangle1.CalculatePerimeter()}");
        Console.WriteLine($"Діагоналі: {rectangle1.CalculateDiagonals()}");
        Console.WriteLine($"Тип прямокутника: {rectangle1.DetermineRectangleType()}");

        Console.WriteLine($"Прямокутники рівні: {rectangle1.Equals(rectangle2)}");
    }
}
