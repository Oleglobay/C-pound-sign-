using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "hello, world";
            Console.WriteLine("Starts with \"world\": " + text.StartsWith("Hello"));
            Console.WriteLine("Starts with \"hello\": " + text.StartsWith("hello"));
            Console.WriteLine("Starts with \"hello\": " + text.StartsWith("hello"));
            Console.WriteLine("Ends with \"hello\": " + text.StartsWith("hello"));
            Console.WriteLine("ends with \"world\": " + text.StartsWith("world"));
            Console.ReadKey();
        }
    }
}
