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
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x - Math.Truncate(x));
            Console.ReadKey();
        }
    }
}