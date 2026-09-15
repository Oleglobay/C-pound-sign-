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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Keypress(object sender, EventArgs e)
        {
            if (e.KeyChar == (char)System.Windows.Forms.Keys.Enter)
                label1.BackColor = System.Drawing.Color.Aqua;

        }
    }
}
