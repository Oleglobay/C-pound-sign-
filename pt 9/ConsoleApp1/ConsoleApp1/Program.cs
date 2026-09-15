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
            string s = "helo";
            Console.WriteLine("sey your name");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(s + a);
            Console.ReadKey();
        }
    }   
}
