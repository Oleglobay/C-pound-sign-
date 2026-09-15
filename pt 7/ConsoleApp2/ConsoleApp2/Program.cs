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
            do
            {
                Console.WriteLine(count);
                count++;
            }
            while (count < 5);

            do
            {
                Console.WriteLine(c);
                c--;
            }
            while (c < 0);

            Console.ReadKey();
        }
    }
}
