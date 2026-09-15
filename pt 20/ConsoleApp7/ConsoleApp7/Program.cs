using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Student
    {
        public class biografi
        {
            string Name;
            string Stependiya;
            int Kurs;
            

            public biografi()
            {
                Name = "Mercedes";
                Stependiya = "yes";
                Kurs = 2;
                Print();
            }
            public biografi (string Name, string Stependiya, int Kurs)
            {
                this.Name = Name;
                this.Stependiya = Stependiya;
                this.Kurs = Kurs;
                Print();
            }
            public void Print()
            {
                Console.WriteLine($"name:{Name}|stependiya:{Stependiya}|kurs:{Kurs}|");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                biografi Mercedes = new biografi();
                Console.ReadKey();
            }
        }
    }
}
