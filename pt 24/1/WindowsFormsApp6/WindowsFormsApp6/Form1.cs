using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
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
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f2 = new Form2();
            DialogResult r = f2.ShowDialog();
            switch (r)
            {
                case DialogResult.OK:
                    break;
                case DialogResult.Abort:
                    e.Cancel = true;
                    break;
                case DialogResult.Retry:
                    break;

                    string message = "Все – так все !";
                    string caption = "Повідомлення";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
            }
        } 
    }
}

