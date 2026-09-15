using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12345; 
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10; 
                sum += digit; 
                n /= 10; 
            }
            Console.ReadLine();
        }
    }
}
