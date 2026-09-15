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
    public partial class Form2 : Form
    {
        static public Form1 f1 = null;
        static public Form2 f2 = null;
        static public Form3 f3 = null;
        static public Form4 f4 = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//дане вікно закривається
            Form1.f2 = null;//після того як форма закрилась, присвоюємо відповідним змінним значення null, для передачі цих значень у інші форми, щоб було відомо що дана форма була закрита. 
            Form3.f2 = null;
            Form4.f2 = null;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)// функція, яка відповідає за те якщо форму закрили за допомогою червоно хрестика
        {
            //після того як форма закрилась, присвоюємо відповідним змінним значення null, для передачі цих значень у інші форми, щоб було відомо що дана форма була закрита.
            Form1.f2 = null;
            Form3.f2 = null;
            Form4.f2 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (f3 == null) // перевірка умови чи форма три активна чи ні, якщо не створена значення null то форма створиться, якщо форма створена то просто вона відкриється і активується.
                f3 = new Form3();
            f3.Show();
            f3.Activate();
            Form1.f2 = null; // присвоєння значення null для змінних, бо ми закриваємо форму коли переходимо на іншу, і це значення має передатись у інші форми (те що наша форма закрита)
            Form3.f2 = null;
            Form4.f2 = null;
            this.Close(); // закриється дана форма
        }

    }
}
