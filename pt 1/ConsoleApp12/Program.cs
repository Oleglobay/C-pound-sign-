using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iloveanime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c;
            n = Convert.ToInt32(Console.ReadLine());
            a = n / 100;
            b = n % 100 / 10;
            c = n % 10;
            Console.WriteLine(a + b + c);
            Console.ReadKey();
        }
    }
}