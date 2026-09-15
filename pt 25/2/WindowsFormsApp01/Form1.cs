using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dx = 5;//створення змінних для задання швидкості руху по х і у
        int dy = 5;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)// перевірка, яка кнопка нажата (ліво)
            {
                dx = -5;// рух в ліво, зміна позиції по х на п’ять в ліво
                dy = 0;// у не змінюється
                timer1.Start();// початок руху (запускається таймер)
            }
            if (e.KeyCode == Keys.Right)
            {
                dx = 5;
                dy = 0;
                timer1.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                dy = -5;
                dx = 0;
                timer1.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                dy = 5;
                dx = 0;
                timer1.Start();
            }
            if (e.KeyCode == Keys.Space)
            {
                dx = 0;
                dy = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += dx;// зміна позиції мітки по х
            label1.Top += dy;// зміна позиції мітки по у
            if (label1.Top <= 0)// перевірка чи досягнутий край форми згори
                dy = -dy;// відбиття від стінки згори (зміна значення змінної на протилежну)

            if (label1.Top + label1.Height + 40 >= this.Height) // перевірка чи досягнутий край форми знизу
                dy = -dy;

            if (label1.Left + label1.Width + 20 >= this.Width) // перевірка чи досягнутий край форми зправа
                dx = -dx;

            if (label1.Left <= 0) // перевірка чи досягнутий край форми зліва
                dx = -dx;

        }
    }
}
