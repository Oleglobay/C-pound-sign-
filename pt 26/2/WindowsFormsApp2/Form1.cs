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
            contextMenuStrip1.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
                this.Close();

        }

        private void exitF10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enableToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (enableToolStripMenuItem.Checked == true)
            {
                button1.Enabled = true;
            }
            if (enableToolStripMenuItem.Checked == false)
            {
                button1.Enabled = false;
            }
        }

        private void panel1CaptionBibaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Biba";
        }

        private void btnFaceToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            btnFaceToolStripMenuItem.Checked = true;
            panel1.BackColor = Color.Firebrick;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
        }

        private void redToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            redToolStripMenuItem.Checked = true;
            panel1.BackColor = Color.Red;
            btnFaceToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
        }

        private void blueToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            blueToolStripMenuItem.Checked = true;
            panel1.BackColor = Color.Red;
            btnFaceToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
        }

        private void yellowToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            yellowToolStripMenuItem.Checked = true;
            panel1.BackColor = Color.Red;
            btnFaceToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
        }
    }
}
