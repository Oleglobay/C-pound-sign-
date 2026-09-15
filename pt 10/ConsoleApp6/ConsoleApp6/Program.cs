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
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }


            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    int square = array[i] * array[i];
                    Console.WriteLine($"Квадрат числа {number} = {square}");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}

