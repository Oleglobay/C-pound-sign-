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
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button button1 = new System.Windows.Forms.Button();
            button1.Parent = panel1;
            button1.Width = 100;
            button1.Height = 50;
            button1.Left = 50;
            button1.Top = 12;
            button1.Text = "Натисніть на кнопку";
            button1.Click += new System.EventHandler(f);
            timer1.Stop();

        }
        private void f(object sender, EventArgs e)//функція, яка викликається після натискання на другу кнопку
        {
            // колір форми
            timer2.Start();// запуск другого таймера
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            timer3.Start();
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
