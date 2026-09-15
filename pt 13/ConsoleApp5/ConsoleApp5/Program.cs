using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static bool ahahh(int[] array)
        {


            foreach (int number in array)
            {
                if (number % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            bool result = ahahh(numbers);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
