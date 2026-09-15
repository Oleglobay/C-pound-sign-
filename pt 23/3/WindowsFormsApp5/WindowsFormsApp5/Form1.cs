using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap bmpDraw;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "bmp";
            openFileDialog1.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmpDraw = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bmpDraw;
                pictureBox1.Invalidate();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "bmp";
            saveFileDialog1.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bmpDraw.Save(saveFileDialog1.FileName,
                    System.Drawing.Imaging.ImageFormat.Bmp);
                }
                catch (Exception)
                {
                    MessageBox.Show("There was a problem saving the file: " +
                    "'" + saveFileDialog1.FileName + "'");
                }
            }
        }

    }
}
