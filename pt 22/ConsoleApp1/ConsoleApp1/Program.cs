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
            try
            {
                
                int a = 10;
                int b = 0;
                int result = a / b; 
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Помилка: Ділення на нуль.");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Виникла невідома помилка: " + ex.Message);
            }



        }
    }
}
