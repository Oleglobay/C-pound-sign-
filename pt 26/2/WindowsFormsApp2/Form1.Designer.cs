
namespace _0
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1CaptionBibaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitF10ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(138, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button1ToolStripMenuItem,
            this.viewToolStripMenuItem1,
            this.exitF10ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 70);
            // 
            // button1ToolStripMenuItem
            // 
            this.button1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem});
            this.button1ToolStripMenuItem.Name = "button1ToolStripMenuItem";
            this.button1ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.button1ToolStripMenuItem.Text = "Button1";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Checked = true;
            this.enableToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.CheckedChanged += new System.EventHandler(this.enableToolStripMenuItem_CheckedChanged);
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panel1colorToolStripMenuItem,
            this.panel1CaptionBibaToolStripMenuItem});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.viewToolStripMenuItem1.Text = "Panel";
            // 
            // panel1colorToolStripMenuItem
            // 
            this.panel1colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFaceToolStripMenuItem,
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.yellowToolStripMenuItem});
            this.panel1colorToolStripMenuItem.Name = "panel1colorToolStripMenuItem";
            this.panel1colorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.panel1colorToolStripMenuItem.Text = "Panel1.color";
            // 
            // btnFaceToolStripMenuItem
            // 
            this.btnFaceToolStripMenuItem.Checked = true;
            this.btnFaceToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnFaceToolStripMenuItem.Name = "btnFaceToolStripMenuItem";
            this.btnFaceToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.btnFaceToolStripMenuItem.Text = "BtnFace";
            this.btnFaceToolStripMenuItem.CheckedChanged += new System.EventHandler(this.btnFaceToolStripMenuItem_CheckedChanged);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.CheckedChanged += new System.EventHandler(this.redToolStripMenuItem_CheckedChanged);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.CheckedChanged += new System.EventHandler(this.blueToolStripMenuItem_CheckedChanged);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Checked = true;
            this.yellowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.CheckedChanged += new System.EventHandler(this.yellowToolStripMenuItem_CheckedChanged);
            // 
            // panel1CaptionBibaToolStripMenuItem
            // 
            this.panel1CaptionBibaToolStripMenuItem.Name = "panel1CaptionBibaToolStripMenuItem";
            this.panel1CaptionBibaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.panel1CaptionBibaToolStripMenuItem.Text = "Panel1.Caption = \"Biba\"";
            this.panel1CaptionBibaToolStripMenuItem.Click += new System.EventHandler(this.panel1CaptionBibaToolStripMenuItem_Click);
            // 
            // exitF10ToolStripMenuItem1
            // 
            this.exitF10ToolStripMenuItem1.Name = "exitF10ToolStripMenuItem1";
            this.exitF10ToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.exitF10ToolStripMenuItem1.Text = "Exit F10";
            this.exitF10ToolStripMenuItem1.Click += new System.EventHandler(this.exitF10ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 296);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem button1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitF10ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem panel1colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnFaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panel1CaptionBibaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

