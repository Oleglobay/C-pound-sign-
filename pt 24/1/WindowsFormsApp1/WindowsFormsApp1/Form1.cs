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
            Form2 f2 = new Form2();
            DialogResult r = f2.ShowDialog();
            switch (r)
            {
                case DialogResult.OK:
                    textBox1.Text = "OK";
                    break;
                case DialogResult.Abort:
                    textBox1.Text = "Abort";
                    break;
                case DialogResult.Retry:
                    textBox1.Text = "Retry";
                    break;
            }
        }
    }
}
