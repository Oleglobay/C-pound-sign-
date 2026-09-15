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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

    }
}
