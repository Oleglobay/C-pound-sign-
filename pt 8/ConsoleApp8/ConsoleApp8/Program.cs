using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int size = 10;
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 10);
            }

            for (int i = 0; i < size; i =+2)
            {
                Console.WriteLine("element z parnim cheslom {0} : {1}", i, array[i]);
            }
            Console.ReadKey();
        }
    }
}
