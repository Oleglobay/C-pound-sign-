using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;


            int[] array = GenerateRandomArray(size, -10, 10);

            Console.WriteLine("Початковий вектор:");
            PrintArray(array);

            int countEven = CountEvenElements(array);
            Console.WriteLine("Кількість парних елементів: " + countEven);
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

        static int CountEvenElements(int[] array)
        {
            int count = 0;
            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
