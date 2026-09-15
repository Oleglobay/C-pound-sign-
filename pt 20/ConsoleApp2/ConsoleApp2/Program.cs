using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class box
        {
            public double length;
            public double width;
            public double height;

            public double Oby()
            {
                return height * length * width;
            }
        }
        class BOX2
        {
            static void Main(string[] args)
            {
                box haha = new box();
                
                haha.length = 5;
                haha.width = 5;
                haha.height = 10;

                double oby = haha.Oby();
                Console.WriteLine(oby);

                box haha1 = new box();

                haha1.length = 5;
                haha1.width = 5;
                haha1.height = 10;

                Console.WriteLine(haha1.Oby());
                Console.ReadKey();
            }
        }
            
    }
}
