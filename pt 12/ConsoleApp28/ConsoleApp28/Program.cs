using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 44, 88, 66, 11, 88 };
            num.RemoveAll(88);
            for (int i = 0; i < num.Count; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
