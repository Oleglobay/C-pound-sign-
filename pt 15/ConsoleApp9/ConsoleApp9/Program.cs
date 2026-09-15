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
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> list2 = new List<int> { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            CompareLists(list1, list2);
            CalculateSums(list1, list2);
            FindMinMax(list1, list2);
            SwapElements(list1, list2);
            ConvertToWords(list1);
        }

        static void CompareLists(List<int> list1, List<int> list2)
        {
            Console.WriteLine("Елементи, що є тільки в одному або в іншому списку:");

            List<int> uniqueElements = new List<int>();

            foreach (int num in list1)
            {
                if (!list2.Contains(num))
                {
                    uniqueElements.Add(num);
                }
            }

            foreach (int num in list2)
            {
                if (!list1.Contains(num))
                {
                    uniqueElements.Add(num);
                }
            }

            foreach (int num in uniqueElements)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
        }

        static void CalculateSums(List<int> list1, List<int> list2)
        {
            int sum1 = 0;
            int sum2 = 0;

            foreach (int num in list1)
            {
                sum1 += num;
            }

            foreach (int num in list2)
            {
                sum2 += num;
            }

            Console.WriteLine($"Сума елементів першого списку: {sum1}");
            Console.WriteLine($"Сума елементів другого списку: {sum2}");
            Console.WriteLine();
        }

        static void FindMinMax(List<int> list1, List<int> list2)
        {
            int min1 = list1[0];
            int max1 = list1[0];

            foreach (int num in list1)
            {
                if (num < min1)
                {
                    min1 = num;
                }

                if (num > max1)
                {
                    max1 = num;
                }
            }

            int min2 = list2[0];
            int max2 = list2[0];

            foreach (int num in list2)
            {
                if (num < min2)
                {
                    min2 = num;
                }

                if (num > max2)
                {
                    max2 = num;
                }
            }

            Console.WriteLine($"Мінімальний елемент першого списку: {min1}");
            Console.WriteLine($"Максимальний елемент першого списку: {max1}");
            Console.WriteLine($"Мінімальний елемент другого списку: {min2}");
            Console.WriteLine($"Максимальний елемент другого списку: {max2}");
            Console.WriteLine();
        }

        static void SwapElements(List<int> list1, List<int> list2)
        {
            int temp1 = list1[0];
            int temp2 = list2[list2.Count - 1];

            list1[0] = temp2;
            list2[list2.Count - 1] = temp1;

            Console.WriteLine("Списки після обміну перших та останніх елементів:");
            Console.WriteLine("Перший список: " + string.Join(", ", list1));
            Console.WriteLine("Другий список: " + string.Join(", ", list2));
            Console.WriteLine();
        }

        static void ConvertToWords(List<int> list)
        {
            Console.WriteLine("Перший список цифри словами:");

            Dictionary<int, string> numberWords = new Dictionary<int, string>
        {
            { 0, "нуль" },
            { 1, "один" },
            { 2, "два" },
            { 3, "три" },
            { 4, "чотири" },
            { 5, "п'ять" },
            { 6, "шість" },
            { 7, "сім" },
            { 8, "вісім" },
            { 9, "дев'ять" },
            { 10, "десять" }
        };

            foreach (int num in list)
            {
                if (numberWords.ContainsKey(num))
                {
                    Console.WriteLine(numberWords[num]);
                }
            }
        }
    }
}
