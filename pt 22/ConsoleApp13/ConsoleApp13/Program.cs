using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int subarraySize = 4;

        try
        {
            int[][] subarrays = SplitArray(array, subarraySize);

            for (int i = 0; i < subarrays.Length; i++)
            {
                Console.WriteLine($"Підмасив {i + 1}: [{string.Join(", ", subarrays[i])}]");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Виняток: {ex.Message}");
        }
    }

    static int[][] SplitArray(int[] array, int subarraySize)
    {
        if (subarraySize <= 0 || subarraySize > array.Length)
        {
            throw new ArgumentException("Розмір підмасиву має бути більший за 0 і не перевищувати розмір основного масиву.");
        }

        int numberOfSubarrays = (int)Math.Ceiling((double)array.Length / subarraySize);
        int[][] subarrays = new int[numberOfSubarrays][];

        for (int i = 0; i < numberOfSubarrays; i++)
        {
            int remainingElements = Math.Min(subarraySize, array.Length - i * subarraySize);
            subarrays[i] = new int[remainingElements];

            Array.Copy(array, i * subarraySize, subarrays[i], 0, remainingElements);
        }

        return subarrays;
    }
}

