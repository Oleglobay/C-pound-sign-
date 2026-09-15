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
            int count = 0;
            int c = 5;
            while (count < 5)
            {
                Console.WriteLine(count);
                count++;
            };
            while (c < 0)
            {
                Console.WriteLine(c);
                c--;
            };
            Console.ReadKey();
        }
    }
}
