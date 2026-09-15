using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введіть число");

            string text = Console.ReadLine();
            if (int.TryParse(text, out int vaule))
            {
                Console.WriteLine("введене значеня цифра");
            }
            else
            {
                Console.WriteLine("введене значеня не цифра");
            }
            Console.ReadKey();
        }
    }
}
