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
            List<int> numbers = new List<int>() {23, 56, 99};
            for (int f = 0; f < numbers.Count; f++)
                Console.Write(numbers[f] + " ");
            Console.ReadKey();
        }
    }
}
