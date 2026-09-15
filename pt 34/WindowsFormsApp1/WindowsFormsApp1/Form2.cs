using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\робочий стіл\робочий стіл переглянути\Методички Романові\C# візуал\InventoryManagementSystem\Tutorial Database\dbIMS.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                textBox1.UseSystemPasswordChar = true;
            else
                textBox2.UseSystemPasswordChar = false;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Applicaton", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                cm.Parameters.AddWithValue("@username", textBox1.Text);
                cm.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Welcome " + dr["fullname"].ToString() + "    ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form4 main = new Form4();
                    this.Hide();
                    main.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "ACCESS DENITED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
