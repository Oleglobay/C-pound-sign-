using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;


            int[] array = GenerateRandomArray(size, -10, 10);

            Console.WriteLine("Початковий вектор:");
            PrintArray(array);


            int minEvenElement = FindMinEvenElement(array);
            int minEvenIndex = Array.IndexOf(array, minEvenElement);


            SwapFirstWithMinEven(array, minEvenIndex);

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

        static int FindMinEvenElement(int[] array)
        {
            int minEvenElement = int.MaxValue;
            foreach (int element in array)
            {
                if (element % 2 == 0 && element < minEvenElement)
                {
                    minEvenElement = element;
                }
            }
            return minEvenElement;
        }

        static void SwapFirstWithMinEven(int[] array, int minEvenIndex)
        {
            if (array.Length < 2 || minEvenIndex == -1)
            {
                return; 
            }

            int temp = array[0];
            array[0] = array[minEvenIndex];
            array[minEvenIndex] = temp;
        }
    
    }
}
