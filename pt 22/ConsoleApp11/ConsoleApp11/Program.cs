using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input);
            CheckPrime(number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка формату числа. Введіть коректне ціле число.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Виняток: {ex.Message}");
        }
    }

    static void CheckPrime(int number)
    {
        if (number < 2)
        {
            throw new ArgumentException("Число повинно бути не менше 2.");
        }

        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{number} - просте число.");
        }
        else
        {
            Console.WriteLine($"{number} - не просте число.");
        }
    }
}

