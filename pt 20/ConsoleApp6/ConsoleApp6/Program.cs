using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class car
    {
        public string Master = "wolswgen";
        public string Model = "pasat";
        public int Year = 2010;
        public string Color = "yelow"; 
        public int Prise = 10000;
        public string Roof = "yes";

        public void Print()
        {
            Console.WriteLine($"Master: {Master}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Prise: {Prise}");
            Console.WriteLine($"Roof: {Roof}");
        }
    }
    class program
    {
        static void Main1(string[] args)
        {
            car oleg = new car();
            Console.WriteLine($"\n Master: {oleg.Master} \n Model: {oleg.Model}  \n Year: {oleg.Year} \n color: {oleg.Color} \n Prise: {oleg.Prise} \n Roof: {oleg.Roof}");
            car kola = new car();
            kola.Master = "Mazda";
            kola.Model = "FD";
            kola.Year = 2011;
            kola.Color = "yelow";
            kola.Prise = 11000;
            kola.Roof = "yes";
            kola.Print();
            Console.ReadKey();
        }
    }
    
        public class Automobile
        {//поля класу (class fields) - описують стан об'єкта цього класу.
            string vyrobnuk;//інформація про виробника,
            string model;//модель,   
            int rikVypusku;//рік випуску,
            string kolir;//колір,
            double tsina;//ціна автомобіля,
            bool vidkydnyiDakh;//чи має автомобіль відкидний дах.

            public Automobile()
            {
                vyrobnuk = "Mercedes";
                model = "CLS";
                rikVypusku = 2017;
                kolir = "Червоний";
                tsina = 55000;
                vidkydnyiDakh = false;
                Print();
            }
            public Automobile(string vyrobnuk, string model, int rikVypusku, string kolir, double tsina, bool vidkydnyiDakh)
            {
                this.vyrobnuk = vyrobnuk;
                this.model = model;
                this.rikVypusku = rikVypusku;
                this.kolir = kolir;
                this.tsina = tsina;
                this.vidkydnyiDakh = vidkydnyiDakh;
                Print();
            }
            public void Print()
            {
                Console.WriteLine($"|Vyrobnuk:{vyrobnuk}|Model:{model}|RikVypusku:{rikVypusku}|Kolir:{kolir}|Tsina:{tsina}|VidkydnyiDakh:{vidkydnyiDakh}|");
            }
        }
        class Program
        {
            static void Main2(string[] args)
            {
                Automobile Mercedes = new Automobile();
                Automobile Ford = new Automobile("Ford", "Mustang", 2016, "Жовтий", 34000, true);
                Console.ReadKey();
            }
        }
    
}
