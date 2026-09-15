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
            string text = "Hello, world";
            Console.WriteLine("Contains \"world\": " + text.Contains("world"));
            Console.WriteLine("Contains \"hello\": " + text.Contains("hello"));
            Console.WriteLine("Contains \"Hello\": " + text.Contains("Hello"));
            Console.WriteLine("Contains \"hi\": " + text.Contains("hi"));
            Console.ReadKey();
        }
    }
}
