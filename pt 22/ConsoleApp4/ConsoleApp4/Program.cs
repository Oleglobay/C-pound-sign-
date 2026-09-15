using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        try
        {

            Array.Sort(array);


            int element = GetElementByIndex(array, 10);

            Console.WriteLine($"Елемент за індексом 10: {element}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Виняток: {ex.Message}");
        }
    }

    static int GetElementByIndex(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Індекс виходить за межі масиву.");
        }

        return array[index];
    }
}
