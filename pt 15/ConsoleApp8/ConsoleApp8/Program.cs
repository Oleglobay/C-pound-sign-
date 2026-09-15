using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "абвгде";
            string str2 = "123456";

            string result = SwapEvenCharacters(str1, str2);

            Console.WriteLine(result);
        }

        static string SwapEvenCharacters(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                throw new ArgumentException("Рядки мають різну довжину!");
            }

            char[] chars1 = str1.ToCharArray();
            char[] chars2 = str2.ToCharArray();

            for (int i = 0; i < chars1.Length; i += 2)
            {
                char temp = chars1[i];
                chars1[i] = chars2[i];
                chars2[i] = temp;
            }

            return new string(chars1) + Environment.NewLine + new string(chars2);
            Console.ReadKey();
        }
    }
}
    

