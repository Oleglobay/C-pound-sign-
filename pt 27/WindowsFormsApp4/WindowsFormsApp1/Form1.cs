using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = "move Edit1 => last ListBox1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Text = "move current ListBox1 => last ListBox2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button1.Text = "first ListBox1 <= move current ListBox2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button1.Text = "move current ListBox2 => Edit2";
        }
    }
}
