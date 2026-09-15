using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "ggdfo", "dasdfds", "saadad", "dasdas" };

            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
