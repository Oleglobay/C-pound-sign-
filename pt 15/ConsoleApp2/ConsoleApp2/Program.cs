using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть трицифрове ціле число:");
            int number = Convert.ToInt32(Console.ReadLine());

            int digit1 = number / 100; 
            int digit2 = (number / 10) % 10; 
            int digit3 = number % 10; 

            int sum = digit1 + digit2 + digit3;

            Console.WriteLine("Сума цифр числа: {0}", sum);

            if (sum < 5)
            {
                Console.WriteLine("Перша цифра числа: {0}", digit1);
            }
            else if (sum >= 5 && sum <= 10)
            {
                Console.WriteLine("Середня цифра числа: {0}", digit2);
            }
            else if (sum > 10 && sum <= 20)
            {
                Console.WriteLine("Третя цифра числа: {0}", digit3);
            }
            else
            {
                int product = number * sum;
                Console.WriteLine("Добуток числа на суму цифр: {0}", product);
            }

            Console.ReadLine();
        }
    }
}
