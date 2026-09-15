using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 44, 88, 66, 22 };
            int e = num[-1];
            for (int i = 0; i < num.Count; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
