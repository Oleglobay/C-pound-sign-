using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 7;

            switch (n)
            {
                case 1:
                    label1.Text = "невихідний";
                    break;
                case 2:
                    label1.Text = "невихідний";
                    break;
                case 3:
                    label1.Text = "невихідний";
                    break;
                case 4:
                    label1.Text = "невихідний";
                    break;
                case 5:
                    label1.Text = "невихідний";
                    break;
                case 6:
                    label1.Text = "вихідний";
                    break;
                case 7:
                    label1.Text = "вихідний";
                    break;
            }
            Console.ReadKey();
        }
    }
}
