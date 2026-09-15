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
            string[] strings = { "Hello", "World", "OpenAI", "Chatbot" };
            char targetChar = 'o';

            int count = 0;
            foreach (string str in strings)
            {
                foreach (char ch in str)
                {
                    if (ch == targetChar)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Кількість входжень символу '" + targetChar + "': " + count);

            Console.ReadLine();
        }
    }
}
