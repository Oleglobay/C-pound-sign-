using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Console.Read();

            if ((a % 2) == 0)
            {
                Console.WriteLine("parne");
            }
            else
            {
                Console.WriteLine("ne parne");
            }
            Console.ReadKey();
        }
    }
}
