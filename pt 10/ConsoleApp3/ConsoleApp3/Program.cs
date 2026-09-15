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
            int[,] m = new int[6, 5];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"element ({i + 0}, {j + 0}): ");
                    m[i, j] = 0
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
