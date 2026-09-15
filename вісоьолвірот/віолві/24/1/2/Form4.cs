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
    public partial class Form4 : Form
    {
        static public Form1 f1 = null;
        static public Form2 f2 = null;
        static public Form3 f3 = null;
        static public Form4 f4 = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f1 == null)
                f1 = new Form1();
            f1.Show();
            f1.Activate();
            Form2.f4 = null;
            Form3.f4 = null;
            Form1.f4 = null;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2.f4 = null;
            Form3.f4 = null;
            Form1.f4 = null;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.f4 = null;
            Form3.f4 = null;
            Form1.f4 = null;
        }
    }
}
