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
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"plocha = {s}");
            Console.ReadKey();
        }
    }
}