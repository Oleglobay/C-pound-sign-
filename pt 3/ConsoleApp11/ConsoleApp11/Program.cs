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
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int b = 2;
            if (a / b)
            {
                Console.WriteLine(a / b) ;
            }
            else
            {
                Console.WriteLine("Not work");
            }

        }
    }
}
