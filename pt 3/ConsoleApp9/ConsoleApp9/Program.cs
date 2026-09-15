using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            
            int b = int.Parse(Console.ReadLine());
            
            int c = int.Parse(Console.ReadLine());

            int count = 0;
            if (a == b)
            {
               count++;
            }
            if (a == c) 
            {
                count++;
            }
            if (b == c) 
            {
                count++;
            }
            Console.WriteLine("кількість" + count);

        }
    }
}
