using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 99 && a < 1000)
            {
                Console.WriteLine(a % 100 / 10);
            }
            else
            {
                Console.WriteLine("це число не трицефрове");
            }
            Console.ReadLine();

        }
    }
}
