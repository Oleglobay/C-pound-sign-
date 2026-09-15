
namespace WindowsFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.tbProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbProductTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.tbProductTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProductBindingSource
            // 
            this.tbProductBindingSource.DataMember = "tbProduct";
            this.tbProductBindingSource.DataSource = this.database1DataSet;
            // 
            // tbProductTableAdapter
            // 
            this.tbProductTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.pqtyDataGridViewTextBoxColumn,
            this.ppriceDataGridViewTextBoxColumn,
            this.pdescriptionDataGridViewTextBoxColumn,
            this.pcategoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbProductBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "pid";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "pname";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "pname";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            // 
            // pqtyDataGridViewTextBoxColumn
            // 
            this.pqtyDataGridViewTextBoxColumn.DataPropertyName = "pqty";
            this.pqtyDataGridViewTextBoxColumn.HeaderText = "pqty";
            this.pqtyDataGridViewTextBoxColumn.Name = "pqtyDataGridViewTextBoxColumn";
            // 
            // ppriceDataGridViewTextBoxColumn
            // 
            this.ppriceDataGridViewTextBoxColumn.DataPropertyName = "pprice";
            this.ppriceDataGridViewTextBoxColumn.HeaderText = "pprice";
            this.ppriceDataGridViewTextBoxColumn.Name = "ppriceDataGridViewTextBoxColumn";
            // 
            // pdescriptionDataGridViewTextBoxColumn
            // 
            this.pdescriptionDataGridViewTextBoxColumn.DataPropertyName = "pdescription";
            this.pdescriptionDataGridViewTextBoxColumn.HeaderText = "pdescription";
            this.pdescriptionDataGridViewTextBoxColumn.Name = "pdescriptionDataGridViewTextBoxColumn";
            // 
            // pcategoryDataGridViewTextBoxColumn
            // 
            this.pcategoryDataGridViewTextBoxColumn.DataPropertyName = "pcategory";
            this.pcategoryDataGridViewTextBoxColumn.HeaderText = "pcategory";
            this.pcategoryDataGridViewTextBoxColumn.Name = "pcategoryDataGridViewTextBoxColumn";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(275, 331);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tbProductBindingSource;
        private Database1DataSetTableAdapters.tbProductTableAdapter tbProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcategoryDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}