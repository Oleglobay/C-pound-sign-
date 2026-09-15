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
            int size = 10;


            int[] array = GenerateRandomArray(size, -10, 10);

            Console.WriteLine("Початковий вектор:");
            PrintArray(array);

            int maxElement = array[0];
            int minElement = array[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    maxIndex = i;
                }
                else if (array[i] < minElement)
                {
                    minElement = array[i];
                    minIndex = i;
                }
            }


            Console.WriteLine("Максимальний елемент: " + maxElement);
            Console.WriteLine("Мінімальний елемент: " + minElement);

  
            double avgIndexMax = (double)maxIndex;
            double avgIndexMin = (double)minIndex;

            Console.WriteLine("Середнє арифметичне індексів максимального і мінімального елементів:");
            Console.WriteLine("Максимальний індекс: " + avgIndexMax);
            Console.WriteLine("Мінімальний індекс: " + avgIndexMin);

            if (avgIndexMax > avgIndexMin)
            {
                Console.WriteLine("Індекс максимального елемента більший.");
            }
            else if (avgIndexMax < avgIndexMin)
            {
                Console.WriteLine("Індекс мінімального елемента більший.");
            }
            else
            {
                Console.WriteLine("Індекси максимального і мінімального елементів рівні.");
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
    }
}
