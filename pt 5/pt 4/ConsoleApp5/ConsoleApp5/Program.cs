using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 2;

            switch (n)
            {
                case 1:
                    label1.Text = "Трамвай маршрут 12 відстань 25 км";
                    break;
                case 2:
                    label2.Text = "бус маршрут 16 відстань 50 км";
                    break;
                case 3:
                    label3.Text = "таксі маршрут 12 відстань 25 км";
                    break;
            }
            Console.ReadKey();
        }
    }
}
