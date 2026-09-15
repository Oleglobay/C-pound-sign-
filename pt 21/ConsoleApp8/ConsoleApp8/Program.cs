using System;
using System.Collections.Generic;

class Set
{
    private List<char> elements;

    public Set()
    {
        elements = new List<char>();
    }

    public void Add(char symbol)
    {
        if (!elements.Contains(symbol))
        {
            elements.Add(symbol);
        }
    }

    public int Count()
    {
        return elements.Count;
    }

    public void Display()
    {
        Console.Write("Множина: { ");
        foreach (char symbol in elements)
        {
            Console.Write($"{symbol} ");
        }
        Console.WriteLine("}");
    }

    public void MySymb(string text)
    {
        foreach (char symbol in text)
        {
            if (symbol == '<' || symbol == '>' || symbol == '=')
            {
                Add(symbol);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        string inputText = "a < b + c = d > e + f";

        Set symbolSet = new Set();
        symbolSet.MySymb(inputText);

        int count = symbolSet.Count();

        symbolSet.Display();

        Console.WriteLine($"Кількість елементів: {count}");
    }
}
