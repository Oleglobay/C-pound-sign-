using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int a = r.Next(0, 10);
            Console.WriteLine(a);
            Console.ReadKey();

            Random y = new Random();
            int d = y.Next(0, 10);
            Console.WriteLine(a);
            Console.ReadKey();

            Random g = new Random();
            Byte[] b = new byte[10];
            r.NextBytes(b);
            for (int i = 0; i <= b.GetUpperBound(0); i++)
                Console.WriteLine("{0} : {1}", i, b[i]);
            Console.ReadKey();
        }
    }
}
