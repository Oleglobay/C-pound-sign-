using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 2, 3, 5, 6, 1 };

            List<int> uniqueList = new List<int>();

            foreach (int number in array)
            {
                if (!uniqueList.Contains(number))
                {
                    uniqueList.Add(number);
                }
            }

            int[] uniqueArray = uniqueList.ToArray();

            foreach (int element in uniqueArray)
            {
                Console.WriteLine(element);
            }

        }
    }
}
