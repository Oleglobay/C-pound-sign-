using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class animal
    {
        public string name = "oleg";
        public int age = 10;

        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"hapiness: {hapiness}");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            animal oleny = new animal();
            Console.WriteLine($"\n Name: {oleny.name} \n Age: {oleny.age} \n Hapiness: {oleny.hapiness}");
            animal oleny2 = new animal();
            oleny2.name = "kola";
            oleny2.age = 8;
           
            oleny2.Print();
            Console.ReadKey();
        }
    }
}

