using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class boob
    {
        private string boob1;
        private int boob2;

        public boob()
        {
            this.boob1 = "ok";
            this.boob2 = 0;
        }
        public boob(string boob1, int boob2)
        {
            this.boob1 = boob1;
            this.boob2 = boob2;
        }
        public void wowboob()
        {
            Console.WriteLine($"pole 1: {this.boob1}, pole2; {this.boob2}");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            boob dood = new boob();
            dood.wowboob();
            boob dood2 = new boob();
            dood2.wowboob();
            Console.ReadKey();
        }
    }
}
