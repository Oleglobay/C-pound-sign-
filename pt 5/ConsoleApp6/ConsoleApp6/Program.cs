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
            goto label;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            ladel:
            Console.ReadLine();
        }
    }
}
