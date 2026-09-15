using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число більше 10:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Дільники числа {0}:", number);

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                    hdshgyudhs(number, i);
                }
            }

            Console.ReadLine();
        }

        static void hdshgyudhs(int number, int divisor)
        {
            Console.WriteLine("Табличка множення на {0}:", divisor);

            for (int i = 1; i <= 10; i++)
            {
                int result = divisor * i;
                Console.WriteLine("{0} * {1} = {2}", divisor, i, result);
            }

            Console.WriteLine();
        }
    }
}
