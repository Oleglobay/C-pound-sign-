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
            double x = -4.0; 
            double endX = 4.0;
            double step = 0.5;

            while (x <= endX)
            {
                double y = 5 + 2 * x - 10;
                Console.WriteLine("x = {0}, y = {1}", x, y);
                x += step;
            }
            Console.ReadLine();
        }
    }
}
