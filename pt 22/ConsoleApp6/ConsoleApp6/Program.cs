using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> myList = new List<string> { "item1", "item2", "item3" };

        try
        {

            RemoveItemByIndex(myList, 2);

            Console.WriteLine("Список після видалення:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Виняток: {ex.Message}");
        }
    }

    static void RemoveItemByIndex(List<string> list, int index)
    {
        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException("Індекс виходить за межі списку.");
        }

        list.RemoveAt(index);
    }
}
