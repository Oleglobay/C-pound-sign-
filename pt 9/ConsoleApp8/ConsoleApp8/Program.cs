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
            string text = "hello world";
            Console.WriteLine(text.Insert(5,","));
            Console.WriteLine(text.Insert(5, "awesome"));
            Console.ReadKey();
        }
    }
}
