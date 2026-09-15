using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Ініціалізуємо масиви файлів і шляхів
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                // Очищаємо список перед додаванням нових елементів
                listBox1.Items.Clear();
                //Метод для додавання всіх медіа файлів у список
                foreach (var filePath in paths)
                {
                    try
                    {
                        var file = TagLib.File.Create(filePath);
                        listBox1.Items.Add(file.Tag.Title);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Помилка читання файлу: {ex.Message}");
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
            textBox1.Text = "Пошук";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TagLib.File.Create(paths[listBox1.SelectedIndex]);
            var file = TagLib.File.Create(paths[listBox1.SelectedIndex]);
            label1.Text = "Назва: " + file.Tag.Title;
            label2.Text = "Альбом: " + file.Tag.Album;
            label3.Text = "Рік: " + file.Tag.Year.ToString();
            try
            {
                var picture = file.Tag.Pictures.FirstOrDefault();
                if (picture != null)
                {
                    var bin = picture.Data.Data;
                    pictureBox1.Image = Image.FromStream(new MemoryStream(bin));
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int index = listBox1.FindString(textBox1.Text);
            if (0 <= index)
            {
                listBox1.SelectedIndex = index;
            }

        }
    }
}
