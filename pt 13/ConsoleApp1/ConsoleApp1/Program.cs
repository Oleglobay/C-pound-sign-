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
            int[] namess = { 1, 2, 3, 4, 5 };
            foreach (int names in namess)
            {
                Console.WriteLine(names);
            }
        }
    }
}
