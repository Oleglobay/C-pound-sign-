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
            Label label1 = new System.Windows.Forms.Label();
            label1.Parent = panel1;
            label1.Width = 100;
            label1.Height = 50;
            label1.Left = 50;
            label1.Top = 12;
            label1.Text = "Натисніть";
            label1.Click += new System.EventHandler(f);
            timer1.Stop();

        }
        private void f(object sender, EventArgs e)//функція, яка викликається після натискання на другу кнопку
        {
            this.BackColor = Color.Blue;
            timer2.Start();// запуск другого таймера
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
