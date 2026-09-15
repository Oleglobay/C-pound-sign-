using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;

            int[] array = GenerateRandomArray(size, -10, 10);

            Console.WriteLine("Початковий вектор:");
            PrintArray(array);

            FindMinOddElementAndIndex(array);
        }

        static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        static void FindMinOddElementAndIndex(int[] array)
        {
            int minOddElement = int.MaxValue;
            int minOddIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] < minOddElement)
                {
                    minOddElement = array[i];
                    minOddIndex = i;
                }
            }

            if (minOddIndex != -1)
            {
                Console.WriteLine("Найменший непарний елемент: " + minOddElement);
                Console.WriteLine("Його індекс: " + minOddIndex);
            }
            else
            {
                Console.WriteLine("В масиві немає непарних елементів.");
            }
            Console.ReadKey();
        }
    }
}
