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
            trackBar1.Value = 5;
            

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = $"{trackBar1.Value}%";
            double seconds = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            label2.Text = time.ToString(@"hh\:mm;\ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            trackBar1.Value = 0;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.rate = 0.5f;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.rate = 1.0f;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.rate = 1.5f;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                trackBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
            //Створення методу для відображення часу початку та кінця треку з допомогою міток.
            try
            {
                label_start.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                label_end.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch
            {
            }

        }
    }
}
