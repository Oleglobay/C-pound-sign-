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
            int n;
            int sum = 0;

            do
            {
                n = int.Parse(Console.ReadLine());

                sum += n;
            } 
            while (n != 0);

            Console.ReadLine();
        }
    }
}
