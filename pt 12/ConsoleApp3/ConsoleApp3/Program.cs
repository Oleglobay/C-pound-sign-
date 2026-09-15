using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() {44, 55, 66, 77, 88 ,00};
            int joy = 66;
            if (num.Contains(joy))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            for (int i = 0; i < num.Count; i++)
                Console.Write(num[i] + " ");
            Console.ReadKey();
        }
    }
}
