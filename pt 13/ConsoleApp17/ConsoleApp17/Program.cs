using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Hello", "World", "Example" };

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].ToLower();
            }


            foreach (string element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
