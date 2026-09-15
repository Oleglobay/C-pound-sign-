using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            if (m == 1)
            {
                Console.WriteLine("мізинець");
            }
            else
            {
                if (m == 2)
                {
                    Console.WriteLine("безімений");
                }
                else
                {
                    if (m == 3) 
                    {
                        Console.WriteLine("середній");
                    }
                    else
                    {
                        if (m == 4)
                        {
                            Console.WriteLine("вказівний");
                        }
                        else
                        {
                            if (m == 5)
                            {
                                Console.WriteLine("великий");
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
