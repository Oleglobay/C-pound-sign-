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
            int n;
            n = 7;
            switch (n)
            {
                case 1:
                    label1.Text = "Понеділок встав поїв поспав";
                    break;
                case 2:
                    label2.Text = "Вівторок встав поїв поспав";
                    break;
                case 3:
                    label3.Text = "Середа встав поїв поспав";
                    break;
                case 4:
                    label4.Text = "Четвер встав поїв поспав";
                    break;
                case 5:
                    label5.Text = "П'ятниця встав поїв поспав";
                    break;
                case 6:
                    label6.Text = "Субота встав поїв поспав";
                    break;
                case 7:
                    label7.Text = "Неділя встав поїв поспав";
                    break;
            }

        }
    }
}
