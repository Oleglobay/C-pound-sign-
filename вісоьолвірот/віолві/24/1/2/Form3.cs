using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
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
            Form2.f3 = null;
            Form1.f3 = null;
            Form4.f3 = null;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2.f3 = null;
            Form1.f3 = null;
            Form4.f3 = null;
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.f3 = null;
            Form1.f3 = null;
            Form4.f3 = null;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form2.f3 = null;
            Form1.f3 = null;
            Form4.f3 = null;
        }
    }
}
