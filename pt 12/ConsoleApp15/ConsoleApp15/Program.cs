using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 44, 88, 66, 11 };
            num.Insert(0, 22);
            num.Remove(44);
            num.Remove(11);
            num.Insert(3, 44);
            for (int i = 0; i < num.Count; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
