using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("число a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("число b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("число c");
            int c = int.Parse(Console.ReadLine());
            if((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("pernmtp dorivnye");
                Console.WriteLine($"{a + b + c}");
                Console.WriteLine("plokha dorivhye");
                int p = (a + b + c) / 2;
                Console.WriteLine($"{Math.Sqrt(p * (p - a) * (p - b)*(p - c))}");
            }
            else
            {
                Console.WriteLine("not work");
            }
            Console.ReadKey();
        }     
    }
}
