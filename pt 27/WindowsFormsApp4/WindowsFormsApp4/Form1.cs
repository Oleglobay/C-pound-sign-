using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(selectedItem);
                listBox1.Items.Remove(selectedItem);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Text = string.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string selectedItem = listBox2.SelectedItem.ToString();
                listBox1.Items.Insert(0, selectedItem);
                listBox2.Items.Remove(selectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                textBox2.Text = listBox2.SelectedItem.ToString();
                string selectedItem = listBox2.SelectedItem.ToString();// створення змінної в яку записуємо значення вибраного елемента
                listBox2.Items.Remove(selectedItem);

            }
        }

    }
}
