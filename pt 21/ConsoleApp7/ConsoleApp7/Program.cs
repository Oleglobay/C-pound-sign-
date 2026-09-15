using System;

abstract class Shape
{
    public abstract double SurfaceArea();
}

class Parallelepiped : Shape
{
    private double length;
    private double width;
    private double height;

    public Parallelepiped(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public override double SurfaceArea()
    {
        return 2 * (length * width + length * height + width * height);
    }
}

class Tetrahedron : Shape
{
    private double side;

    public Tetrahedron(double side)
    {
        this.side = side;
    }

    public override double SurfaceArea()
    {
        return Math.Sqrt(3) * side * side;
    }
}

class Sphere : Shape
{
    private double radius;

    public Sphere(double radius)
    {
        this.radius = radius;
    }

    public override double SurfaceArea()
    {
        return 4 * Math.PI * radius * radius;
    }
}

class Program
{
    static void Main()
    {
        Shape[] shapes = new Shape[3];

        shapes[0] = new Parallelepiped(2, 3, 4);
        shapes[1] = new Tetrahedron(5);
        shapes[2] = new Sphere(6);

        for (int i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine($"Площа поверхні об'єкта {i + 1}: {shapes[i].SurfaceArea()}");
        }
    }
}

