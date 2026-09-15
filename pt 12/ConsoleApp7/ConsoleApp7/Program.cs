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
            List<int> num = new List<int>() { 44, 88, 66, 22 };
            num.Reverse();
            for (int i = 0; i < num.Count; i++)
                Console.Write(num[i] + " ");
            Console.ReadKey();
        }
    }
}
