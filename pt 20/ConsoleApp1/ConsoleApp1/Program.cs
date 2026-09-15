using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class programer
        {
            public string Name;
            public int Age;
            public int Work;
            public int Zarplata;

            public programer(string name, int age, int work, int zarplata)
            {
                Name = name;
                Age = age;
                Work = work;
                Zarplata = zarplata;
            }
            public void sayname()
            {
                Console.WriteLine("oleg");
            }
           
        }
    }
}
