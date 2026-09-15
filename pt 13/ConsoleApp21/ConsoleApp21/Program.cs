using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, -2, 3, -4, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = 0;
                }
            }

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
