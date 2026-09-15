using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D, x1, x2;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            D = b * b - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                if (x1 >= x2)
                    Console.WriteLine($"x1 = {x1} x2 = {x2}");
                else
                    Console.WriteLine($"x2 = {x2} x1 = {x1}");
            }
            else if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"x = {x1}");
            }
            else
                Console.WriteLine("wrong");
            Console.ReadKey();
        }
    }
}
