using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); int m = int.Parse(Console.ReadLine());
            int result = (int)Math.Pow(n, m);
            Console.WriteLine($"{n} В степені {m} дорівнює {result}");
            Console.ReadLine();
        }
    }
}
