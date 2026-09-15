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
            int a, c;
            a = Console.Read();
            c = Console.Read();

            if (a > c)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }

            if (a == c)
            {
                Console.WriteLine("0");
            }
            Console.ReadKey();
            
        }
    }
}
