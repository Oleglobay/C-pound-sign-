using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class animal
    {
        public string name = "oleg";
        public int age = 10;

        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"age: {age}");
        }
        public void Print2()
        {
            Console.WriteLine($"Name: {name}");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            animal oleny = new animal();
            Console.WriteLine($"\n Name: {oleny.name} \n Age: {oleny.age}");
            animal oleny2 = new animal();
            oleny2.name = "kola";
            oleny2.Print2();
            Console.ReadKey();
        }
    }
}
