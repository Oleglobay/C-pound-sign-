using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() {44, 88, 66, 22};

            bool evennum = false;
            foreach(int number in num)
            {
                if(number % 2 == 0)
                {
                    evennum = true;
                    break;
                }
            }

            if (evennum)
            {
                 Console.WriteLine("yes");
            }
            else
            {
                 Console.WriteLine("no");
            }
            
            for (int i = 0; i < num.Count; i++)
                Console.Write(num[i] + " ");
            Console.ReadKey();
        }
    }
}
