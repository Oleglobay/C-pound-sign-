using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        string input = Console.ReadLine();

        try
        {
            double number = double.Parse(input);
            double result = CalculateSquareRoot(number);
            Console.WriteLine($"Квадратний корінь з {number} дорівнює {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка формату числа. Введіть коректне число.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Виняток: {ex.Message}");
        }
    }

    static double CalculateSquareRoot(double number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Неможливо обчислити квадратний корінь для від'ємного числа.");
        }

        return Math.Sqrt(number);
    }
}
