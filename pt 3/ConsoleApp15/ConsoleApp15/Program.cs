using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            if (n > 99 && n < 1000)
            Console.WriteLine(n % 100 / 10);
            else if (n > 999 && n < 10000)
            Console.WriteLine(n % 1000 / 10);
            else if (n > 9999 && n < 100000);
            Console.WriteLine(n / 10000 + " " + n % 10);
            else
                Console.WriteLine("wrong");
            Console.ReadKey();


        }
    }
}
