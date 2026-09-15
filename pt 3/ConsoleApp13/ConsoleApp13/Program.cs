using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int m = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            int k = 4;
            if (m * m > && (k % n == 0 || k % m == 0))
            {
               Console.WriteLine("можна");
            }
            else
            {
                Console.WriteLine("не можна");
            }

            Console.ReadKey();
        }
    }
}
