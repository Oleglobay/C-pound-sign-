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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripButton2.Checked == true)
            {
                WindowState = FormWindowState.Maximized;
            }
            if (toolStripButton2.Checked == false)
            {
                WindowState = FormWindowState.Normal;
            }

        }
        private void toolStripButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripButton3.Checked == true)
            {
                toolStripButton4.Enabled = true;
            }
            if (toolStripButton3.Checked == false)
            {
                toolStripButton4.Enabled = false;
            }
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            label1.Text = "напис на мітці";
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            toolStripButton5.Checked = true;
            toolStripButton6.Checked = false;
            toolStripButton7.Checked = false;
        }


        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            toolStripButton5.Checked = false;
            toolStripButton6.Checked = true;
            toolStripButton7.Checked = false;

        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            toolStripButton5.Checked = false;
            toolStripButton6.Checked = false;
            toolStripButton7.Checked = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
