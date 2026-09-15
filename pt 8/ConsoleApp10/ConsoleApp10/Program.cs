using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int size = 100;
            int[] array = new int[size];
            

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100);
            }
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("summ:" + sum);
            Console.ReadKey();
        }
    }
}
