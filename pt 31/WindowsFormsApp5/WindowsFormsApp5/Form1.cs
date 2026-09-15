using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        List<string> str = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            listBox2.Items.Add(textBox1.Text);
            button5.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            foreach (string s in ofd.FileNames)
            {
                listBox1.Items.Add(Path.GetFullPath(s));
                str.Add(s);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.Text;
            button4.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @listBox1.Text;
            axWindowsMediaPlayer1.URL = listBox2.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter Save = new StreamWriter(@"D:\Курси програмування\Oleg Lobay\C#\pt 31\WindowsFormsApp5\TextFile1.txt");
            foreach (var item in listBox2.Items)
            {
                Save.WriteLine(item.ToString());
                this.Refresh();
            }
            MessageBox.Show("Saved to listBox_favorite");
            Save.Close();
            listBox2.Items.Clear();
            button4.Enabled = false;
            button5.Enabled = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (StreamReader read = new StreamReader(@"D:\Курси програмування\Oleg Lobay\C#\pt 31\WindowsFormsApp5\TextFile1.txt"))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    listBox2.Items.Add(line);
                }
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox2.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }

        }
    }
}
