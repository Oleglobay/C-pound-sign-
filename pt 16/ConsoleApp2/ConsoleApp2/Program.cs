using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();
            Console.ReadKey();
        }
        public static void Write()
        {
             int result = 0;
             for (int i = 2; i <= 230; i += 2)
             {
                result += i;
             }
            Console.WriteLine("sdgdshfsdh" + result);
        }
    }
}
