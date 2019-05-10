namespace team_development.UI.QueryEmploy
{
    partial class QueryEmploy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOffer = new System.Windows.Forms.DataGridView();
            this.ColumnJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 25.8F);
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "就业信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewOffer
            // 
            this.dataGridViewOffer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOffer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOffer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOffer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnJob,
            this.ColumnSalary,
            this.ColumnCity,
            this.ColumnEducation});
            this.dataGridViewOffer.Location = new System.Drawing.Point(49, 114);
            this.dataGridViewOffer.Name = "dataGridViewOffer";
            this.dataGridViewOffer.RowTemplate.Height = 27;
            this.dataGridViewOffer.Size = new System.Drawing.Size(939, 395);
            this.dataGridViewOffer.TabIndex = 2;
            this.dataGridViewOffer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnJob
            // 
            this.ColumnJob.HeaderText = "职位";
            this.ColumnJob.Name = "ColumnJob";
            // 
            // ColumnSalary
            // 
            this.ColumnSalary.HeaderText = "薪水";
            this.ColumnSalary.Name = "ColumnSalary";
            // 
            // ColumnCity
            // 
            this.ColumnCity.HeaderText = "城市";
            this.ColumnCity.Name = "ColumnCity";
            // 
            // ColumnEducation
            // 
            this.ColumnEducation.HeaderText = "学历";
            this.ColumnEducation.Name = "ColumnEducation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe 繁黑體 Std B", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(239, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Job Information";
            // 
            // QueryEmploy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOffer);
            this.Controls.Add(this.label1);
            this.Name = "QueryEmploy";
            this.Text = "QueryEmploy";
            this.Load += new System.EventHandler(this.InquiryOffer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEducation;
        private System.Windows.Forms.Label label2;
    }
}