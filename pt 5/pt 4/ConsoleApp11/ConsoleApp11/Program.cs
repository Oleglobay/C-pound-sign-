using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("ведіть число на перевірку кратності 3");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a / 3 ? "можно" : "іди додому");

            Console.WriteLine("ведіть число на перевірку кратності 7");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a / 7 ? "можно" : "іди додому");

            Console.ReadLine();
        }
    }
}
