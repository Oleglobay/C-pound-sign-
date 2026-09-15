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
    public partial class Form2 : Form
    {
        static public Form1 f1 = null;
        static public Form2 f2 = null;
        static public Form3 f3 = null;
        static public Form4 f4 = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f1 == null)
                f1 = new Form1();
            f1.Show();
            f1.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f3 == null)
                f3 = new Form3();
            f3.Show();
            f3.Activate();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (f1 == null)
                f1 = new Form1();
            f1.Show();
            f1.Activate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (f3 == null)
                f3 = new Form3();
            f3.Show();
            f3.Activate();
        }
    }
}
