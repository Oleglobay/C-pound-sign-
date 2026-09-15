using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a > a : " + String.Compare("a","a"));
            Console.WriteLine("a > b : " + String.Compare("a", "b"));
            Console.WriteLine("b > a : " + String.Compare("b", "a"));
            Console.WriteLine("ab > abc: " + String.Compare("ab", "abc"));
            Console.WriteLine("a > A : " + String.Compare("a", "A"));
            Console.WriteLine("a > A : " + String.Compare("a", "A",true));
            Console.WriteLine("hello > world : " + String.Compare("hello", "world"));
            Console.ReadKey();
        }
    }
}
