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
            
            int[] array = { 0, 1, 2, 3, 4, 5 };
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
