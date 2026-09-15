using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
                textBox1.BackColor = System.Drawing.Color.Aqua;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }
    }
}
