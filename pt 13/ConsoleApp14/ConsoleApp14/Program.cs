using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, -8, 2, -10, 3, -1, 0, 7 };

            int count = 0;
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Кількість від'ємних чисел: " + count);

            Console.ReadLine();
        }
    }
}
