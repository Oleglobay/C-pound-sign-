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
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((double)a / b);
            Console.ReadKey();
        }
    }
}