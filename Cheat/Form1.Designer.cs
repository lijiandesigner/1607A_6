namespace Cheat
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "考试结束时间：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(569, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(153, 30);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "选择扫描文件夹...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColSize,
            this.ColTime});
            this.dataGridView1.Location = new System.Drawing.Point(15, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(707, 277);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 378);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(114, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "导出Excel";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "总文件大小（M）：";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(617, 383);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 12);
            this.lblSize.TabIndex = 6;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            this.ColName.HeaderText = "文件名";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColSize
            // 
            this.ColSize.DataPropertyName = "Size";
            this.ColSize.HeaderText = "文件大小（字节）";
            this.ColSize.Name = "ColSize";
            this.ColSize.ReadOnly = true;
            // 
            // ColTime
            // 
            this.ColTime.DataPropertyName = "Time";
            this.ColTime.HeaderText = "文件修改时间";
            this.ColTime.Name = "ColTime";
            this.ColTime.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "作弊警察";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
    }
}

