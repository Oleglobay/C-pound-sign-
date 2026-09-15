using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            this.Visible = true;
            this.Enabled = true;
            this.Focus();
            this.Size = new Size(100, 100);
            this.Size = new Size(r.Next(133, 567), r.Next(133, 567));
        }
    }
}
