using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class bank
    {
        public class money
        {
            int griwns;
            int coins;


            public money()
            {
                griwns = 53;
                coins = 2;
                Print();
            }
            public money(int coins, int griwns)
            {
                this.griwns = griwns;
                this.coins = coins;
                Print();
            }
            public void Print()
            {
                Console.WriteLine($"{griwns},{coins}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            { 
                money ffd = new money();
                Console.ReadKey();
            }
        }
    }
}
