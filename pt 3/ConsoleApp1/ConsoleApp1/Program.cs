using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());

            if (a > 10)
            {
                Console.WriteLine("більше 10");
            } else
            {
                Console.WriteLine("менше 10");
            }
            Console.ReadKey();
        }
    }
}
