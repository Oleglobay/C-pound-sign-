using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5]
        {
            { 1, 0, 0, 0, 0 },
            { 0, 2, 0, 0, 0 },
            { 0, 0, 3, 0, 0 },
            { 0, 0, 0, 4, 0 },
            { 0, 0, 0, 0, 5 }
        };

            Console.WriteLine("Головна діагональ матриці:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
