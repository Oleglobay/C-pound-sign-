using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;


            int[] array = GenerateRandomArray(size, -10, 10);


            Console.WriteLine("Початковий вектор:");
            PrintArray(array);


            double avgEven = CalculateAverageOfEvenElements(array);
            double avgOdd = CalculateAverageOfOddElements(array);

            Console.WriteLine("Середнє арифметичне парних елементів: " + avgEven);
            Console.WriteLine("Середнє арифметичне непарних елементів: " + avgOdd);


            if (avgEven > avgOdd)
            {
                Console.WriteLine("Середнє арифметичне парних елементів більше.");
            }
            else if (avgEven < avgOdd)
            {
                Console.WriteLine("Середнє арифметичне непарних елементів більше.");
            }
            else
            {
                Console.WriteLine("Середні арифметичні парних і непарних елементів рівні.");
            }
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

        static double CalculateAverageOfEvenElements(int[] array)
        {
            int sum = 0;
            int count = 0;
            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    sum += element;
                    count++;
                }
            }
            return count > 0 ? (double)sum / count : 0.0;
        }

        static double CalculateAverageOfOddElements(int[] array)
        {
            int sum = 0;
            int count = 0;
            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    sum += element;
                    count++;
                }
            }
            return count > 0 ? (double)sum / count : 0.0;
        }
    }
}
