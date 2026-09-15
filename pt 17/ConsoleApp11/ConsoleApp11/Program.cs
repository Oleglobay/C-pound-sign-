using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 6;

            int[] array = GenerateRandomArray(size, -10, 10);


            Console.WriteLine("Початковий вектор:");
            PrintArray(array);


            SwapElementsInOrder(array);

            Console.WriteLine("Вектор після обміну:");
            PrintArray(array);
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

        static void SwapElementsInOrder(int[] array)
        {
            int n = array.Length / 2;
            for (int i = 0; i < n; i++)
            {
                int temp = array[i];
                array[i] = array[i + n];
                array[i + n] = temp;
            }
        }
    }
}
