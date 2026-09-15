using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            Console.Write("Введіть число: ");
            int number = int.Parse(Console.ReadLine());

            bool isPresent = false;

            foreach (int element in array)
            {
                if (element == number)
                {
                    isPresent = true;
                    break;
                }
            }

            if (isPresent)
            {
                Console.WriteLine("Число присутнє в масиві.");
            }
            else
            {
                Console.WriteLine("Число відсутнє в масиві.");
            }
            Console.ReadKey();
        }
    }
    
}
