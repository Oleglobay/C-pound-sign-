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
            this.Close();
            Form3.f2 = null;
            Form4.f2 = null;

        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.f2 = null;
            Form3.f2 = null;
            Form4.f2 = null;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (f3 == null)
                f3 = new Form3();
            f3.Show();
            f3.Activate();
            Form1.f2 = null;
            Form3.f2 = null;
            Form4.f2 = null;
            this.Close(); 
        }

    }
}
