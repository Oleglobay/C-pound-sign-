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
            Random r = new Random();
            var s = 0;
            var n = 0;
            int[,] m = new int[6, 5];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int a = r.Next(0, 10);
                    m[i, j] = n;
                    s += n;
                    Console.WriteLine(n);
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
            
            Console.ReadKey();
        }
    }
}
