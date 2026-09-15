using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Console.Write("Введіть число: ");
            int number = int.Parse(Console.ReadLine());

            int index = Array.IndexOf(array, number);

            if (index != -1)
            {
                Console.WriteLine("Індекс першого входження числа: " + index);
            }
            else
            {
                Console.WriteLine("Число не знайдено у масиві.");
            }

        }
    }
}
