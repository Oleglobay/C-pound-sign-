using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 88, 77, 66, 55, 44, 33, 22, 11, 00 };
            num.Reverse();
            for (int i = 0; i < num.Count; i++)
                Console.Write(num[i] + " ");
            Console.ReadKey();
        }
    }
}
