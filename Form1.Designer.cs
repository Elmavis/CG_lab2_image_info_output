namespace Lab2_Fileinfo_output_WinForms
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
            this.bt_click = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_compression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_click
            // 
            this.bt_click.Location = new System.Drawing.Point(576, 12);
            this.bt_click.Name = "bt_click";
            this.bt_click.Size = new System.Drawing.Size(106, 411);
            this.bt_click.TabIndex = 0;
            this.bt_click.Text = "Get information!";
            this.bt_click.UseVisualStyleBackColor = true;
            this.bt_click.Click += new System.EventHandler(this.Bt_click_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_name,
            this.col_size,
            this.col_resolution,
            this.col_depth,
            this.col_compression});
            this.dgv1.Location = new System.Drawing.Point(12, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(558, 385);
            this.dgv1.TabIndex = 1;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(100, 403);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(470, 20);
            this.tbAddress.TabIndex = 2;
            this.tbAddress.Text = "C:\\Users\\taras\\OneDrive\\Desktop\\Univer\\CG\\Labs\\Lab2_Fileinfo_output\\Lab2_Fileinfo" +
    "_output_WinForms\\bin\\Debug\\test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Адрес файлов:";
            // 
            // col_name
            // 
            this.col_name.HeaderText = "Название";
            this.col_name.Name = "col_name";
            this.col_name.Width = 150;
            // 
            // col_size
            // 
            this.col_size.HeaderText = "Размер";
            this.col_size.Name = "col_size";
            this.col_size.Width = 70;
            // 
            // col_resolution
            // 
            this.col_resolution.HeaderText = "Разрешение";
            this.col_resolution.Name = "col_resolution";
            this.col_resolution.Width = 95;
            // 
            // col_depth
            // 
            this.col_depth.HeaderText = "Глубина";
            this.col_depth.Name = "col_depth";
            // 
            // col_compression
            // 
            this.col_compression.HeaderText = "Сжатие";
            this.col_compression.Name = "col_compression";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.bt_click);
            this.Name = "Form1";
            this.Text = "File info application";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_click;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_resolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_compression;
    }
}

