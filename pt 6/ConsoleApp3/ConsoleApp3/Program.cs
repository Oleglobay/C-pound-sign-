using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = new DateTime(2023, 5, 12, 10, 0, 0);
            DateTime endTime = new DateTime(2023, 5, 12, 18, 0, 0);

            DateTime currentTime = startTime;

            while (currentTime <= endTime)
            {
                Console.WriteLine(currentTime.ToString("yyyy-MM-dd HH:mm:ss"));
                currentTime = currentTime.AddMinutes(15); 
            }
            Console.ReadLine();
        }
    }
}
