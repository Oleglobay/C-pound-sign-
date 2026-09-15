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
            int w;
            n = 2;
            w = 5;
            Console.WriteLine("1.+ 2.- 3.* 4./");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.WriteLine($"{n + w}");
                    break;
                case 2:
                    Console.WriteLine($"{n - w}");
                    break;
                case 3:
                    Console.WriteLine($"{n * w}");
                    break;
                case 4:
                    Console.WriteLine($"{n / w}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
