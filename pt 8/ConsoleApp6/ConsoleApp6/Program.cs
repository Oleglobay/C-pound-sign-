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
            int size = 10;
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 11);
            }
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }
            double average =double)sum / size;
            Console.WriteLine("середнє арефметичне" + average);
            Console.ReadKey();
        }
    }
}
