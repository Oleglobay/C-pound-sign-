using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Point previousPoint, currentPoint;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            InitImage();
        }

 
        private void InitImage()
        {
            Image image = global::MyPaint.Properties.Resources._new; int width = image.Width;
            int height = image.Height;

            pictureBox1.Width = width; pictureBox1.Height = height;

            bmp = new Bitmap(image, width, height);

            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                previousPoint.X = e.X; previousPoint.Y = e.Y;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Color currentColor = Color.Black;
                Pen blackPen = new Pen(currentColor, 1);
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                // поточна координата мишки currentPoint.X = e.X; currentPoint.Y = e.Y;

                // рисуємо елементарний відрізок
                // ( previousPoint - визначається в обробнику
                //	події pictureBox1_MouseDown ) 
                g.DrawLine(blackPen, previousPoint, currentPoint);

                // звільняємо ресурси blackPen.Dispose(); g.Dispose();
                // оновлюємо pictureBox1 
                pictureBox1.Invalidate();
                // поточна координата стане попередньою
                // для наступної побудови 
                previousPoint = currentPoint;
            }
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            InitImage();
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // створили openDialog
            OpenFileDialog openDialog = new OpenFileDialog(); openDialog.Title = "Відкрити рисунок ..."; openDialog.Filter =
            "Image files (*.BMP, *.JPG, *.GIF, *.TIF," + "*.PNG, *.ICO, *.EMF, *.WMF)|*.bmp; *.jpg;" +
            "*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            // якщо вибір - відкрити рисунок
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                // створили image на основі відкритого рисунку 
                Image image = Image.FromFile(openDialog.FileName);
                int width = image.Width;
                int height = image.Height;

                // встановили розміри pictureBox1 
                pictureBox1.Width = width;
                pictureBox1.Height = height;

                // створили "полотно" для рисування 
                bmp = new Bitmap(image, width, height);

                // розмістили "полотно" на pictureBox1 
                pictureBox1.Image = bmp;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // створили saveDialog
            SaveFileDialog saveDialog = new SaveFileDialog(); saveDialog.Title = "Зберегти рисунок як ...";

            saveDialog.OverwritePrompt = true;
            saveDialog.CheckPathExists = true;
            saveDialog.Filter =
            "Bitmap File(*.bmp)|*.bmp|" + "GIF File(*.gif)|*.gif|" + "JPEG File(*.jpg)|*.jpg|" + "TIF File(*.tif)|*.tif|" + "PNG File(*.png)|*.png";
            saveDialog.ShowHelp = true;

            // якщо вибір - зберегти рисунок
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // отримали ім'я файлу
                string fileName = saveDialog.FileName;
                // отримали розширення імені файлу 
                string strFilExtn =
                fileName.Remove(0, fileName.Length - 3);

                // зберігаємо 
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName,
                        System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName,
                        System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName,
                        System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp.Save(fileName,
                        System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName,
                        System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

