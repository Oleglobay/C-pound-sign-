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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6());
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
