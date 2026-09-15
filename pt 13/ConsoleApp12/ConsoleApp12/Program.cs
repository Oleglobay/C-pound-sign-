using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 5, 8, 2, 10, 3 };

            int min = num[0];
            int max = num[0];

            foreach (int number in num)
            {
                if (number < min)
                {
                    min = number;
                }

                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("Мінімальний елемент: " + min);
            Console.WriteLine("Максимальний елемент: " + max);

            Console.ReadLine();
        }
    }
}
