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

        private void radioButton1_Click(object sender, EventArgs e)//для зміни кольору на стандартний (radioButton1)
        {
            label1.BackColor = Color.Cyan;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)//для зміни кольору на червоний (radioButton2)
        {
            label1.BackColor = Color.Red;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)//для зміни кольору на синій (radioButton1)
        {
            label1.BackColor = Color.Blue;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//функція для максимізації вікна і зменшення (checkBox1)
        {
            if (checkBox1.Checked == true)//якщо галочка стоїть
            {
                WindowState = FormWindowState.Maximized;// збільшення вікна до розмірів екрану
            }
            if (checkBox1.Checked == false)// якщо галочки немає
            {
                WindowState = FormWindowState.Normal;// зменшення вікна
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)// функція для зміни видимості мітки (checkBox2)
        {
            if (checkBox2.Checked == true)// якщо галочка стоїть
            {
                label1.Visible = true;// видимість мітки
            }
            if (checkBox2.Checked == false)// якщо галочки немає
            {
                label1.Visible = false;// мітки не видно
            }
        }

    }
}
