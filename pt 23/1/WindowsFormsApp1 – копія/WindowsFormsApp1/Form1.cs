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

        private void button2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = button2;
            this.BackColor = Color.Red;

            label1.BackColor = Color.Black;
            this.Size = new Size(1000, 1000);
            this.Cursor = Cursors.No;
            this.Text = "vsdfui";
            button1.Enabled = false;
            button1.Visible = false;
            this.Location = new System.Drawing.Point(200, 100);
            label1.Location = new System.Drawing.Point(200, 100);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Size = new Size(150, 250);
            this.Text = "vsdfui";
        }
    }
}
