using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
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
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine("suma" + sum);
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
