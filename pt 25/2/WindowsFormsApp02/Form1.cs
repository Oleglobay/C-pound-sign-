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
        int dx = 5;
        int dy = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
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
            label1.Left += dx;
            label1.Top += dy;
            if (label1.Top <= 0)
                dy = -dy;
            if (label1.Left <= 0)
                dx = -dx;
            if (label1.Top + label1.Height >= this.panel1.Height)
                dy = -dy;
            if (label1.Left + label1.Width >= this.panel1.Width)
                dx = -dx;
            if ((label1.Left + label1.Width >= label2.Left &&
            label1.Left + label1.Width <= label2.Left + label2.Width
            ||/*Знак логічного або*/
            label1.Left >= label2.Left &&
            label1.Left <= label2.Left + label2.Width)
            &&
            (label1.Top + label1.Height >= label2.Top &&
            label1.Top + label1.Height <= label2.Top + label2.Height
            ||
            label1.Top >= label2.Top &&
            label1.Top <= label2.Top + label2.Height))//перемірка чи мітка один наїхала на мітку2
            {
                timer1.Stop();
                MessageBox.Show("Game over!");// вивід повідомлення
            }

        }
    }
}
