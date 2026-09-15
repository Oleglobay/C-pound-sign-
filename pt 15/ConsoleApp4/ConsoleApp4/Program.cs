using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int number = random.Next(1, 10);
                Console.WriteLine("Число: {0}", number);

                long factorial = fdsfds(number);
                Console.WriteLine("Факторіал: {0}", factorial);

                int power = GetPower(i, 10);
                long result = (long)Math.Pow(number, power);
                Console.WriteLine("Піднесення до степеня {0}: {1}", power, result);

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static long fdsfds(int number)
        {
            long factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static int GetPower(int currentIndex, int totalNumbers)
        {
            return (currentIndex + 1) % totalNumbers;
        }
    }
    
}
