using System;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
            button1.Text = "Натисніть";
            button1.Click += new System.EventHandler(f);
            timer1.Stop();
        }
        private void f(object sender, EventArgs e)//функція, яка викликається після натискання на другу кнопку
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            

        }

        
    }
}
