using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array = new int[50];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(20, 61);
            }

            Console.WriteLine("Всі числа:");
            PrintArray(array);

            Console.WriteLine("Унікальні значення:");
            int[] uniqueValues = GetUniqueValues(array);
            PrintArray(uniqueValues);

            Console.WriteLine("Парні числа:");
            int[] evenNumbers = GetEvenNumbers(array);
            PrintArray(evenNumbers);

            Console.WriteLine("Непарні числа, кратні 3:");
            int[] oddMultiplesOfThree = GetOddMultiplesOfThree(array);
            PrintArray(oddMultiplesOfThree);

            Console.ReadLine();
        }

        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        static int[] GetUniqueValues(int[] array)
        {
            int[] uniqueValues = new int[array.Length];
            int uniqueCount = 0;

            foreach (int number in array)
            {
                if (Array.IndexOf(uniqueValues, number) == -1)
                {
                    uniqueValues[uniqueCount] = number;
                    uniqueCount++;
                }
            }

            Array.Resize(ref uniqueValues, uniqueCount);
            return uniqueValues;
        }

        static int[] GetEvenNumbers(int[] array)
        {
            int[] evenNumbers = new int[array.Length];
            int evenCount = 0;

            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    evenNumbers[evenCount] = number;
                    evenCount++;
                }
            }

            Array.Resize(ref evenNumbers, evenCount);
            return evenNumbers;
        }

        static int[] GetOddMultiplesOfThree(int[] array)
        {
            int[] oddMultiplesOfThree = new int[array.Length];
            int oddCount = 0;

            foreach (int number in array)
            {
                if (number % 2 != 0 && number % 3 == 0)
                {
                    oddMultiplesOfThree[oddCount] = number;
                    oddCount++;
                }
            }

            Array.Resize(ref oddMultiplesOfThree, oddCount);
            return oddMultiplesOfThree;
            Console.ReadKey();
        }
    }
}
