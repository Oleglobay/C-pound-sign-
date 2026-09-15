using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hello world";
            Console.WriteLine("H - " + text.IndexOf("H"));
            Console.WriteLine("World - " + text.IndexOf("World"));
            Console.WriteLine(", - " + text.IndexOf(","));
            Console.WriteLine("IT - " + text.IndexOf("IT"));
        }
    }
}
