using System;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        static public Form1 f1 = null;
        static public Form2 f2 = null;
        static public Form3 f3 = null;
        static public Form4 f4 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f2 == null)
                f2 = new Form2();
            f2.Show();
            f2.Activate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f4 == null)
                f4 = new Form4();
            f4.Show();
            f4.Activate();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.f1 = null;
            Form3.f1 = null;
            Form4.f1 = null;
        }
    }
}
