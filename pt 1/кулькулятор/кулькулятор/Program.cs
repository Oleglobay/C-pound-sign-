using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace кулькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("перше число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("друге число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"good+: {a} + {b} = {a + b}");
            Console.WriteLine($"good-: {a} - {b} = {a - b}");
            Console.WriteLine($"good*: {a} * {b} = {a * b}");
            Console.WriteLine($"good/: {a} / {b} = {a / b}");
            Console.WriteLine($"good octachi wid dilena: {a} % {b} = {a % b}");
            Console.ReadKey();
        }
    }
}
