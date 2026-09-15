using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Частина_5_Visual_приклад_0_існтр_кнопки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripButton2.Checked == true)//якщо галочка стоїть
            {
                WindowState = FormWindowState.Maximized;// збільшення вікна до розмірів екрану
            }
            if (toolStripButton2.Checked == false)// якщо галочки немає
            {
                WindowState = FormWindowState.Normal;// зменшення вікна
            }
        }

        private void toolStripButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripButton3.Checked == true)//якщо галочка стоїть
            {
                toolStripButton4.Enabled = true;// доступна кнопка 4
            }
            if (toolStripButton3.Checked == false)// якщо галочки немає
            {
                toolStripButton4.Enabled = false;// недоступна кнопка  4
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
    }
}
