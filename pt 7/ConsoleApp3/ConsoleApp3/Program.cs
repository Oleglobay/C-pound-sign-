using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 

            int factorial = 1;
            int i = 1;

            do
            {
                factorial *= i;
                i++;
            } 
            while (i <= n);
            Console.ReadLine();
        }
    }
}
