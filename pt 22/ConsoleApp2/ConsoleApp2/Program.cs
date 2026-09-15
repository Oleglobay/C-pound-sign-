using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Введіть перше число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введіть друге число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());



                Console.Write("Виберіть операцію (+, -, *, /): ");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("Ділення на нуль неможливе.");
                        }
                        result = num1 / num2;
                        break;
                    default:
                        throw new InvalidOperationException("Невідома операція.");
                }
                
                Console.WriteLine($"Результат: {result}");
                
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Помилка: Неправильний формат числа.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Помилка: Ділення на нуль.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Помилка: Невідома операція.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }

}
