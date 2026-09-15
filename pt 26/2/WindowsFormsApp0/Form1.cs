using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void exitF10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
                this.Close();

        }

        private void maximizedToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (maximizedToolStripMenuItem.Checked == true)
            {
                WindowState = FormWindowState.Maximized;
            }
            if (maximizedToolStripMenuItem.Checked == false)
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void lable1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                label1.Text = "БОДЯ";
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = true;
            label1.Font = new Font(label1.Font.Name, 8);
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripMenuItem3.Checked = true;
            label1.Font = new Font(label1.Font.Name, 16);
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem4.Checked = false;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripMenuItem4.Checked = true;
            label1.Font = new Font(label1.Font.Name, 24);
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem2.Checked = false;
        }

    }
}
