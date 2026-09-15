using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 2, 10, 3 };

            int max = int.MinValue;

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number; 
                }
            }

            Console.WriteLine("Найбільший елемент: " + max);

            Console.ReadLine();
        }
    }
}
