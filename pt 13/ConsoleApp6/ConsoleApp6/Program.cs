using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "unaskilol", "kolala", "kf1lol" };

        foreach (string str in strings)
        {
            string[] words = str.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        Console.ReadLine();
        }
    }
}
