using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Частина_5_Visual_приклад_1_списки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))//провірка чи в textBox є текст
            {
                listBox1.Items.Add(textBox1.Text);// в listBox1 добавляєм текст з textBox1 в кінець
                textBox1.Text = string.Empty; //очищаєм textBox1 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)// провірка чи вибрано якийсь елемент в listBox1
            {
                string selectedItem = listBox1.SelectedItem.ToString();// створення змінної в яку записуємо значення вибраного елемента
                listBox2.Items.Add(selectedItem);//в listBox2 добавляєм вибраний текст з listBox1 в кінець
                listBox1.Items.Remove(selectedItem);//видалєм вибраний елемент з listBox1
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)// провірка чи вибрано якийсь елемент в listBox2
            {
                string selectedItem = listBox2.SelectedItem.ToString();// створення змінної в яку записуємо значення вибраного елемента
                listBox1.Items.Insert(0, selectedItem);//в listBox1 добавляєм вибраний текст з listBox2 на початок
                listBox2.Items.Remove(selectedItem);//видалєм вибраний елемент з listBox2
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)// провірка чи вибрано якийсь елемент в listBox2
            {
                textBox2.Text = listBox2.SelectedItem.ToString();// в textBox2 записуємо вибраний елемент з listBox2
                string selectedItem = listBox2.SelectedItem.ToString();// створення змінної в яку записуємо значення вибраного елемента
                listBox2.Items.Remove(selectedItem);//видалєм вибраний елемент з listBox2
            }
        }
    }
}
