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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void currentFilePath_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF Files|*.rtf|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                richTextBox1.LoadFile(currentFilePath);
                Text = currentFilePath;
            }
        }

        private void SaveFile()
        {
            if (currentFilePath != "")
            {
                richTextBox1.SaveFile(currentFilePath);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "RTF Files|*.rtf|All Files|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName;
                    richTextBox1.SaveFile(currentFilePath);
                    Text = currentFilePath;
                }
            }
        }

        private void NewFile()
        {
            richTextBox1.Clear();
            currentFilePath = "";
            Text = "Untitled";
        }

        private void Exit()
        {
            if (richTextBox1.Modified)
            {
                DialogResult result = MessageBox.Show("Document not saved. Save?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            Application.Exit();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }




        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }


        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void leftAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rightAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void centerAlignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }
        у
        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle currentStyle = richTextBox1.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Italic;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, newStyle);
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                FontStyle currentStyle = richTextBox1.SelectionFont.Style;
                FontStyle newStyle = currentStyle ^ FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, newStyle);
            }
        }
    }
}
