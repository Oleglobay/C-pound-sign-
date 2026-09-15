using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть пароль: ");
        string password = Console.ReadLine();

        try
        {
            ValidatePassword(password);
            Console.WriteLine("Пароль введено правильно.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Виняток: {ex.Message}");
        }
    }

    static void ValidatePassword(string password)
    {
        if (password.Length < 8)
        {
            throw new ArgumentException("Пароль надто короткий. Мінімальна довжина пароля - 8 символів.");
        }
    }
}
