using System;

class Rational
{
    private int numerator;   
    private int denominator; 

    public Rational(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Знаменник не може бути рівним нулю.");
        }

        this.numerator = numerator;
        this.denominator = denominator;
        Reduce();  
    }

    
    public double Value()
    {
        return (double)numerator / denominator;
    }


    private void Reduce()
    {
        int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
        numerator /= gcd;
        denominator /= gcd;


        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }
    }


    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }


    public Rational Add(Rational other)
    {
        Rational result = new Rational(
            numerator * other.denominator + other.numerator * denominator,
            denominator * other.denominator);

        result.Reduce();  
        return result;
    }


    public Rational Subtract(Rational other)
    {
        Rational result = new Rational(
            numerator * other.denominator - other.numerator * denominator,
            denominator * other.denominator);

        result.Reduce(); 
        return result;
    }

    public Rational Multiply(Rational other)
    {
        Rational result = new Rational(
            numerator * other.numerator,
            denominator * other.denominator);

        result.Reduce();  
        return result;
    }

    public Rational Divide(Rational other)
    {
        if (other.numerator == 0)
        {
            throw new DivideByZeroException("Ділення на нуль.");
        }

        Rational result = new Rational(
            numerator * other.denominator,
            denominator * other.numerator);

        result.Reduce();  
        return result;
    }

    public bool Equal(Rational other)
    {
        return numerator == other.numerator && denominator == other.denominator;
    }

    public bool GreaterThan(Rational other)
    {
        int lcm = LCM(denominator, other.denominator);
        int aMultiplier = lcm / denominator;
        int bMultiplier = lcm / other.denominator;

        return numerator * aMultiplier > other.numerator * bMultiplier;
    }

    public bool LessThan(Rational other)
    {
        int lcm = LCM(denominator, other.denominator);
        int aMultiplier = lcm / denominator;
        int bMultiplier = lcm / other.denominator;

        return numerator * aMultiplier < other.numerator * bMultiplier;
    }

    private int LCM(int a, int b)
    {
        return Math.Abs(a * b) / GCD(a, b);
    }
}

class Program
{
    static void Main()
    {
        Rational fraction1 = new Rational(3, 4);
        Rational fraction2 = new Rational(2, 5);

        Rational sum = fraction1.Add(fraction2);
        Rational difference = fraction1.Subtract(fraction2);
        Rational product = fraction1.Multiply(fraction2);
        Rational quotient = fraction1.Divide(fraction2);
        bool isEqual = fraction1.Equal(fraction2);
        bool isGreater = fraction1.GreaterThan(fraction2);
        bool isLess = fraction1.LessThan(fraction2);

        Console.WriteLine($"Додавання: {sum.Value()}");
        Console.WriteLine($"Віднімання: {difference.Value()}");
        Console.WriteLine($"Множення: {product.Value()}");
        Console.WriteLine($"Ділення: {quotient.Value()}");
        Console.WriteLine($"Чи рівні: {isEqual}");
        Console.WriteLine($"Чи більше: {isGreater}");
        Console.WriteLine($"Чи менше: {isLess}");
    }
}
