using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Intn
    {
        private int d;
        public Intn (int _d)
        {
            d = _d;
        }
        public int number
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }
        public void display()
        {
            Console.WriteLine("d = {0}", d);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Intn number = new Intn(5);
            number.display();
            number.number = 25;
            number.display();
            int t;
            t = number.number;
            Console.WriteLine("t = {0}", t);
            Console.ReadKey();
        }
    }
}
