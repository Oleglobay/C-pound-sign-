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
            int n = 1;
            int minElement = int.MaxValue; 

            while (n > 0)
            {
                Console.WriteLine(n); 
                if (n < minElement) 
                {
                    minElement = n; 
                }
                n++; 
            }
            Console.ReadLine();
        }
    }
}
