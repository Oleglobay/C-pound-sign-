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
            string text = "hello";
            string text1 = "\t";
            Console.WriteLine("is null or empty " + String.IsNullOrEmpty(text));
            Console.WriteLine("is null or while space " + String.IsNullOrWhiteSpace(text1));
            Console.ReadKey();
        }
    }
}
