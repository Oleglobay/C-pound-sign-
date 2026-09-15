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
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Truncate(a));
            Console.WriteLine(Math.Round(a));
            Console.WriteLine(Math.Ceiling(a));
            Console.WriteLine(Math.Floor(a));
            Console.ReadKey();
        }
    }
}