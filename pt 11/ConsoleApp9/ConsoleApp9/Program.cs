using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int rothmir = int.Parse(Console.ReadLine());

            int[,] matrix = new int[5, 5];

            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {
                Console.Write(matrix[i, row - 1 - i] + " ");
            }
            for (int i = 0; i < row; i++)
            {
                matrix[i, row - 1 - i] = matrix[i, i];
            }

            for (int i = 0; i < col; i++)
            {
                Console.Write(matrix[i, col - 1 - i] + " ");
            }
            for (int i = 0; i < col; i++)
            {
                matrix[i, col - 1 - i] = matrix[i, i];
            }
        }
    }
}
