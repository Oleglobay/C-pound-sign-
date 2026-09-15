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
            int n, k, m;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(((n * 100 + k) * m ) / 100 + "," +((n * 100 + k) * m) % 100);
            Console.ReadKey();
        }
    }
}