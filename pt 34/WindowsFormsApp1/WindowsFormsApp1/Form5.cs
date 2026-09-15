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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\робочий стіл\робочий стіл переглянути\Методички Романові\C# візуал\InventoryManagementSystem\Tutorial Database\dbIMS.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public Form5()
        {
            InitializeComponent();
            LoadProduct();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.tbProduct' table. You can move, or remove it, as needed.
            this.tbProductTableAdapter.Fill(this.database1DataSet.tbProduct);

        }
        public void LoadProduct()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pid, pname, pprice, pdescription, pcategory) LIKE '%" + txtSearch.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form6 formModule = new Form6();
            formModule.button1.Enabled = true;
            formModule.button2.Enabled = false;
            formModule.ShowDialog();
            LoadProduct();

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                Form6 productModule = new Form6();
                productModule.lblPid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModule.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModule.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModule.textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModule.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                productModule.comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

                productModule.btnSave.Enabled = false;
                productModule.btnUpdate.Enabled = true;
                productModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tbProduct WHERE pid LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

