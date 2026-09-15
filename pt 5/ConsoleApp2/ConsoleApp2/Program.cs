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
            for (int i = -1; i <= 8; i++)
            {
                Console.WriteLine(i + 1);
            }

            for (int i = 10; i <= 0; i--)
            {
                Console.WriteLine(i - 1);
            }

            Console.ReadLine();
        }
    }
}
