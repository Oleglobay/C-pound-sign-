using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        int number = int.Parse(Console.ReadLine());

        try
        {
            int factorial = CalculateFactorial(number);
            Console.WriteLine($"Факторіал числа {number}: {factorial}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Виняток: {ex.Message}");
        }
    }

    static int CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факторіал не визначений для від'ємних чисел.");
        }

        return (n == 0 || n == 1) ? 1 : n * CalculateFactorial(n - 1);
    }
}
