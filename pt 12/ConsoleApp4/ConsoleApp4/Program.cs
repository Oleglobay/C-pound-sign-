using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { };
            num.Add(23);
            num.Add(56);
            num.Add(99);
            num.Remove(99);
            for (int i = 0; i < num.Count; i++)
                Console.Write(num[i] + " ");
            Console.ReadKey();
        }
    }
}
