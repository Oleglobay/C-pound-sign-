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
            const int Int = 1;
            const double Double = 1.1;
            const float Float = 1.2f;
            const string String = "String";
            const char Char = '@';
            const bool Bool = true;
            Console.WriteLine($"Int = {Int}, Double = {Double}, Float = {Float}, String = {String}, Char = {Char}, Bool = {Bool}.");
            Console.ReadKey();
        }
    }
}