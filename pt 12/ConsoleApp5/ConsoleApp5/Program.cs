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
            List<int> num = new List<int>() { };
            num.Add(23);
            num.Add(56);
            num.Add(99);
            List<int> newList = new List<int>(num);
            for (int i = 0; i < num.Count; i++)
                Console.Write(num[i] + " ");

            for (int i = 0; i < newList.Count; i++)
                Console.Write(newList[i] + " ");
            Console.ReadKey();
        }
    }
}
