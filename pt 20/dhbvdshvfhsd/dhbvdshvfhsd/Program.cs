using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmer
{
    class Animal
    {//Пропис полів класу типу public та їх заповнення.
        public string name = "Spotty";
        public int age = 7;
        public float hapiness = 0.6f;//Пишеться через кому але можна і так додати в кінці f.

        public void Print()//Виклик метода в класі.
        {//Вивід полів класу через метод.
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Hapiness: {hapiness}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();//Створення об'єкта класу з назвою cat.
            Console.WriteLine($"\n Name: {cat.name} \n Age: {cat.age} \n Hapiness: {cat.hapiness}");
            Animal dog = new Animal();//Створення об'єкта класу з назвою dog.
            dog.name = "Tom";//Присвоєння полю іншій інформації.
            dog.age = 8;
            dog.hapiness = 0.7f;
            dog.Print();//Вивід метода з полями об’єкта класу Animal з назвою dog в головний метод.
            Console.ReadKey();
        }
    }
}