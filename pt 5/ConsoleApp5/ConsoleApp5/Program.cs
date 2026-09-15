using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i > 10; i++)
            {
                n /= 2;
                Console.WriteLine($"n = {n}");
            }
            Console.ReadLine();
        }
    }
}
