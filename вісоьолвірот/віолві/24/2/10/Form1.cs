using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            DialogResult r = f2.ShowDialog();
            switch (r)
            {
                case DialogResult.OK:
                    this.BackColor = Color.Red;
                    f2.Close();
                    break;//виконується приривання функції і програма закривається
                case DialogResult.Abort:
                    f2.Close();//для повернення активності головній формі
                    break;// для приривання case
                case DialogResult.Retry:
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Раніше треба було думати !";// виведене повідомлення на формі
                    string caption = "Повідомлення";// заголовок форми
                    MessageBoxButtons buttons = MessageBoxButtons.OK;// створення кнопки ок
                    DialogResult result;
                    // Вивід повідомлення.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.OK)//якщо натиснута кнопка ок
                    {
                        f2.Close();
                        // Closes the parent form.
                        // повідомлення закривається і стає активною знов головна форма
                    }
                    break; //для приривання case
            }
        }
    }
}
