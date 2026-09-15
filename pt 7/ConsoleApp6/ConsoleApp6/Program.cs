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
            int n;
            int sum = 0;
            int count = 0;

            do
            {
                Console.Write("Введіть число: ");
                n = int.Parse(Console.ReadLine());

                sum += n;

                if (n > 100)
                {
                    count++;
                }
            } 
            while (sum <= 100);

            Console.ReadLine();
        }
    }
}
