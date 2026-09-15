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
            int n = int.Parse(Console.ReadLine());

            

            switch (n )
            {
                case 1:
                    label1.Text = "Понеділок";
                    break;
                case 2:
                    label1.Text = "Вівторок";
                    break;

            }
        }
}
