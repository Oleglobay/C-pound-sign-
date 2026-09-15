using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label label1 = new System.Windows.Forms.Label();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "Hit me";
            label1.Parent = panel1;
            label1.Width = 100;
            label1.Height = 50;
            label1.Left = 50;
            label1.Top = 12;
            label1.MouseEnter += new System.EventHandler(f);
        }
        private void f(object sender, EventArgs e)
        {
            label1.Left = 100;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
