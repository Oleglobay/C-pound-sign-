using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 11);
            }

            int n = array.Length;

            for(int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                while(j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

            foreach (int num in array)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
