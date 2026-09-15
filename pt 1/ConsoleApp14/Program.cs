using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iloveanime
{
    class Program
    {
        static void Main(string[] args)
        {
            int desk;
            desk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(( desk / 2 )+ ( desk % 2 ));
            Console.ReadKey();
        }
    }
}