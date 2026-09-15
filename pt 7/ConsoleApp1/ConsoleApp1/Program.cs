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
            int count = 0;
            do
            {
                Console.WriteLine("hello world");
                count++;
            }
            while (count < 5);
            Console.ReadKey();
        }
    }
}
