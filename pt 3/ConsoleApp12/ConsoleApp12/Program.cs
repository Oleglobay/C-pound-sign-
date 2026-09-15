using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("рік ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("високосний");
            }
            else
            {
                Console.WriteLine("not високосний");
            }
        }
    }
}
