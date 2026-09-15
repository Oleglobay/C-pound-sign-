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
            label1.BackColor = Color.Cyan;
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
                this.Close();
        }
        private void eXITF10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void UpdateComponentsAndWindowState()
        {
            toolStripButton2.Checked = checkBox1.Checked;
            maximizedToolStripMenuItem.Checked = checkBox1.Checked;

            WindowState = checkBox1.Checked ? FormWindowState.Maximized : FormWindowState.Normal;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateComponentsAndWindowState();
        }
        private void toolStripButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = toolStripButton2.Checked;
        }
        private void maximizedToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = maximizedToolStripMenuItem.Checked;
        }

        private void UpdateComponentsAndLABELWISIBLE()
        {
            toolStripButton3.Checked = checkBox2.Checked;
            міткаВидимаToolStripMenuItem.Checked = checkBox2.Checked;

            bool visible = checkBox2.Checked ? true : false;
            label1.Visible = visible;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateComponentsAndLABELWISIBLE();
        }
        private void toolStripButton3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = toolStripButton3.Checked;
        }
        private void міткаВидимаToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = міткаВидимаToolStripMenuItem.Checked;
        }

        private void UpdateControlsBasedOnRadioButton()
        {
            toolStripButton4.Checked = radioButton1.Checked;
            toolStripButton5.Checked = radioButton2.Checked;
            toolStripButton6.Checked = radioButton3.Checked;

            стандартнийToolStripMenuItem.Checked = radioButton1.Checked;
            червонийToolStripMenuItem.Checked = radioButton2.Checked;
            синійToolStripMenuItem.Checked = radioButton3.Checked;

            if (radioButton1.Checked)
            {
                label1.BackColor = Color.Cyan;
            }
            else if (radioButton2.Checked)
            {
                label1.BackColor = Color.Red;
            }
            else if (radioButton3.Checked)
            {
                label1.BackColor = Color.Blue;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControlsBasedOnRadioButton();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControlsBasedOnRadioButton();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControlsBasedOnRadioButton();
        }
        private void toolStripButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = toolStripButton4.Checked;
        }
        private void toolStripButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = toolStripButton5.Checked;
        }
        private void toolStripButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = toolStripButton6.Checked;
        }
        private void стандартнийToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = стандартнийToolStripMenuItem.Checked;
        }
        private void червонийToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = червонийToolStripMenuItem.Checked;
        }
        private void синійToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = синійToolStripMenuItem.Checked;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
