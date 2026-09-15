using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> users = new Dictionary<string, string>
    {
        {"user1", "password1"},
        {"user2", "password2"},
    };

    static void Main()
    {
        Console.Write("Введіть ім'я користувача: ");
        string username = Console.ReadLine();
        Console.Write("Введіть пароль: ");
        string password = Console.ReadLine();

        try
        {
            AuthenticateUser(username, password);
            Console.WriteLine("Авторизація успішна.");
        }
        catch (AuthenticationException ex)
        {
            Console.WriteLine($"Виняток: {ex.Message}");
        }
    }

    static void AuthenticateUser(string username, string password)
    {
        if (!users.ContainsKey(username) || users[username] != password)
        {
            throw new AuthenticationException("Невірне ім'я користувача або пароль.");
        }
    }
}

public class AuthenticationException : Exception
{
    public AuthenticationException(string message) : base(message)
    {
    }
}

