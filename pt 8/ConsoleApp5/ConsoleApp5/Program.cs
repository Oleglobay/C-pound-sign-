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
            int size = 10;
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-10, 11);
            }
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < size; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            Console.WriteLine("найменший елемет" + min);
            Console.WriteLine("найбільший елемет" + max);
            Console.ReadKey();
        }
    }
}
