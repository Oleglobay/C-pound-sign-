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

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        string[] paths, files;

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label_mediaplayer.Text = "Пауза";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (list_track.SelectedIndex < list_track.Items.Count - 1)
            {
                list_track.SelectedIndex = list_track.SelectedIndex + 1;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
            label_start.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            label_end.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();

        }

        private void label_volume(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[list_track.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
           
            label1_mediaplayer.Text = "Відтворюється";
            
            timer1.Start();

            trackBar1.Value = 15;
            label_volume.Text = trackBar1.Value.ToString() + "%";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    list_track.Items.Add(files[i]);
                }
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }
    }
}
