using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "unaskilol", "kolala", "Kf1lol" };

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].ToUpper();
            }

            foreach (string element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
