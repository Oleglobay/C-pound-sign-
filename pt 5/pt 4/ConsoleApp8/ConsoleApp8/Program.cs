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
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a > 10 ? "число більше" : "число менше");
            Console.ReadLine();
        }
    }
}
