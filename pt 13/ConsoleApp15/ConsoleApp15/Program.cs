using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "dasdsa", "dasdsad", "Odasdsa", "ddsad" };

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].ToUpper();
            }

            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
