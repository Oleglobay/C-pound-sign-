using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static int[] fdsfdsfy(int length)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(100);
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] numbers = fdsfdsfy(20);
            PrintArray(numbers);

            int sum = CalculateSum(numbers);
            Console.WriteLine($"Сума елементів, що перевищують наступний: {sum}");
        }


        static void PrintArray(int[] array)
        {
            Console.WriteLine("Масив чисел:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static int CalculateSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    sum += array[i];
                }
            }
            return sum;
            
        }
        
    }
    
}
