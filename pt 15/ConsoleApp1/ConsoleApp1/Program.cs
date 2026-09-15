using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше число:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть степінь для першого числа:");
            int power1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть степінь для другого числа:");
            int power2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть результат піднесення першого числа до степеня:");
            int answer1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть результат піднесення другого числа до степеня:");
            int answer2 = Convert.ToInt32(Console.ReadLine());

            int result1 = (int)Math.Pow(number1, power1);
            int result2 = (int)Math.Pow(number2, power2);

            Console.WriteLine("Перше число піднесене до степеня {0}: {1}", power1, result1);
            Console.WriteLine("Друге число піднесене до степеня {0}: {1}", power2, result2);

            bool isAnswer1Correct = (answer1 == result1);
            bool isAnswer2Correct = (answer2 == result2);

            if (isAnswer1Correct && isAnswer2Correct)
            {
                Console.WriteLine("Відповіді правильні!");
            }
            else
            {
                Console.WriteLine("Відповіді неправильні!");

                if (!isAnswer1Correct)
                {
                    Console.WriteLine("Правильний результат для першого числа: {0}", result1);
                }

                if (!isAnswer2Correct)
                {
                    Console.WriteLine("Правильний результат для другого числа: {0}", result2);
                }
            }

            Console.ReadLine();
        }
    }
}
