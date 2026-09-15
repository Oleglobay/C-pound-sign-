using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;

           
            int[] array = GenerateRandomArray(size, -10, 10);


            Console.WriteLine("Початковий вектор:");
            PrintArray(array);

        
            SwapMaxAndMin(array);

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

        static void SwapMaxAndMin(int[] array)
        {
            if (array.Length == 0)
            {
                return; 
            }

            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
                else if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }


            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;
            Console.ReadKey();
        }
    }
}
