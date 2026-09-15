using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть дату (у форматі dd.MM.yyyy): ");
        string input = Console.ReadLine();

        try
        {
            DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy", null);
            Console.WriteLine($"Введена дата: {date.ToString("dd.MM.yyyy")}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка формату дати. Введіть коректну дату у форматі dd.MM.yyyy.");
        }
    }
}
