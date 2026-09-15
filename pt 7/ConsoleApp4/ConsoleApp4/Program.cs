using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {

                n = int.Parse(Console.ReadLine());
                if (n != 0)
                {
                    Console.WriteLine("Введене число: " + n);
                }
            } 
            while (n != 0);

            Console.ReadLine();
        }
    }
}
