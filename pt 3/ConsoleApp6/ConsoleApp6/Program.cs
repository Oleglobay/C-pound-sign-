using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(DateTime.Now);
            if (a > 6)
            {
                Console.WriteLine("morning");
            }
             else
            {
                Console.WriteLine("night");
            }
            if (a > 12)
            {
                Console.WriteLine("day");
            }
            else
            {
                Console.WriteLine("grey day");
            }
            if (a > 24)
            {
                Console.WriteLine("night");
            }
            else
            {
                Console.WriteLine("morning");
            }
        }
    }
}
