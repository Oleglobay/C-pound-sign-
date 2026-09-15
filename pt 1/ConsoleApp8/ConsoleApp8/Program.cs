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
            int n, k;
            Console.WriteLine("biloche skilke");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("skilke chorihke");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"good: {k / n}");
            Console.ReadKey();
        }
    }
}