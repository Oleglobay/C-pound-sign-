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
            int[,] matrix = new int[5, 5]
            {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { 16, 17, 18, 19, 20 },
            { 21, 22, 23, 24, 25 }
            };

            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int[,] transposet = new int[col, row];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    transposet[i, j] = matrix[j, i];
                    Console.Write(transposet[i,j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();

        }
    }
}
