using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;


            int[] array = GenerateRandomArray(size, -10, 10);

          
            Console.WriteLine("Початковий вектор:");
            PrintArray(array);

            int maxOddElement = FindMaxOddElement(array);
            int maxOddIndex = Array.LastIndexOf(array, maxOddElement);

           
            SwapLastWithMaxOdd(array, maxOddIndex);


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

        static int FindMaxOddElement(int[] array)
        {
            int maxOddElement = int.MinValue;
            foreach (int element in array)
            {
                if (element % 2 != 0 && element > maxOddElement)
                {
                    maxOddElement = element;
                }
            }
            return maxOddElement;
        }

        static void SwapLastWithMaxOdd(int[] array, int maxOddIndex)
        {
            if (array.Length < 2 || maxOddIndex == -1)
            {
                return; 
            }

            int temp = array[array.Length - 1];
            array[array.Length - 1] = array[maxOddIndex];
            array[maxOddIndex] = temp;
        }
    }
}
