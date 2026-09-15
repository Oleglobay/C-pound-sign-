using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 2, 10, 3 };

            double sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = sum / numbers.Length;

            Console.WriteLine("Середнє арифметичне: " + average);

            Console.ReadLine();
        }
    }
}
