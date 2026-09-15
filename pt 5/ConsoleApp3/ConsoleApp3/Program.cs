using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int v;
            int p;
            int e;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            v = Convert.ToInt32(Console.ReadLine());
            p = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b + v + p + e);
            Console.ReadLine();
        }
    }
}
