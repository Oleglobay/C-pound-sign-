using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
                    Console.Write($"element ({i + 1}, {j + 1}): ");
                    m[i, j] = int.Parse(Console.ReadLine());
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
