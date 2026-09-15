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
            int n;
            n = 5;          
            switch (n)
            {
                case 1:
                    label1.Text = "мізінчик";
                    break;
                case 2:
                    label1.Text = "безімений";
                    break;
                case 3:
                    label1.Text = "середній";
                    break;
                case 4:
                    label1.Text = "вказівний";
                    break;
                case 5:
                    label1.Text = "великий";
                    break;
                    Console.ReadKey();
            }

        }
    }
}
