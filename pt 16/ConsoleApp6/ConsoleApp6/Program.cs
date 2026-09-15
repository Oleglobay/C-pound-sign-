using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] arr)
        {
            int[] numbers = new int[5];

            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = random.Next(-10, 10);
            }
            Greate(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            int max = numbers.Max();
            int min = numbers.Min();

            Console.WriteLine("max" + max);
                Console.WriteLine("min" + min);
        }
        static void Greate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }
            Console.ReadKey();
        }
    
    }
}
