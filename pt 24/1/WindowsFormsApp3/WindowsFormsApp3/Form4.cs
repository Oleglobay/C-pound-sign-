using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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
            this.Close();
            Form1.f4 = null;
            Form2.f4 = null;
            Form3.f4 = null;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (f3 == null)
                f3 = new Form3();
            f3.Show();
            f3.Activate();
            Form1.f4 = null;
            Form2.f4 = null;
            Form3.f4 = null;
            this.Close();
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.f4 = null;
            Form2.f4 = null;
            Form3.f4 = null;
        }

    }
}
