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
            int a, c;
            a = Console.Read();
            c = Console.Read();

            if (a > c)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }
            

            if (a == c)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}

    

