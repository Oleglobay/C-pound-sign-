using System;

class Program
{
    static void Main()
    {
        try
        {
            int lowerBound = 10;
            int upperBound = 5;

            int randomNumber = GenerateRandomNumber(lowerBound, upperBound);
            Console.WriteLine($"Випадкове число: {randomNumber}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Виняток: {ex.Message}");
        }
    }

    static int GenerateRandomNumber(int lowerBound, int upperBound)
    {
        if (upperBound <= lowerBound)
        {
            throw new ArgumentException("Верхня межа діапазону повинна бути більшою за нижню межу.");
        }

        Random random = new Random();
        return random.Next(lowerBound, upperBound);
    }
}

