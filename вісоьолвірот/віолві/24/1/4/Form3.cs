using System;
using System.Windows.Forms;

namespace _1
{
    public partial class Form3 : Form
    {
        static public Form1 f1 = null;
        static public Form2 f2 = null;
        static public Form3 f3 = null;
        static public Form4 f4 = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f4 == null)
                f4 = new Form4();
            f4.Show();
            f4.Activate();
            Form1.f3 = null;
            Form2.f3 = null;
            Form4.f3 = null;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f2 == null)
                f2 = new Form2();
            f2.Show();
            f2.Activate();
            Form1.f3 = null;
            Form2.f3 = null;
            Form4.f3 = null;
            this.Close();
        }

    }
}
