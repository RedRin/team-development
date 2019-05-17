namespace team_development.UI.QueryInform
{

    struct Notification
    {
        string Title, PublishAgency, PublishDate;
        public Notification(string MyTitle, string MyPublishAgencty, string MyPublishDate)
        {
            Title = MyTitle;
            PublishAgency = MyPublishAgencty;
            PublishDate = MyPublishDate;
        }
    }

    partial class QueryNotification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewNotifocation = new System.Windows.Forms.DataGridView();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPublishAgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPublishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.infocontent = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifocation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "通知信息\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewNotifocation
            // 
            this.dataGridViewNotifocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotifocation.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNotifocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNotifocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotifocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitle,
            this.ColumnPublishAgency,
            this.ColumnPublishDate});
            this.dataGridViewNotifocation.Location = new System.Drawing.Point(49, 114);
            this.dataGridViewNotifocation.Name = "dataGridViewNotifocation";
            this.dataGridViewNotifocation.RowTemplate.Height = 27;
            this.dataGridViewNotifocation.Size = new System.Drawing.Size(939, 395);
            this.dataGridViewNotifocation.TabIndex = 1;
            this.dataGridViewNotifocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.HeaderText = "标题";
            this.ColumnTitle.Name = "ColumnTitle";
            // 
            // ColumnPublishAgency
            // 
            this.ColumnPublishAgency.HeaderText = "发布单位";
            this.ColumnPublishAgency.Name = "ColumnPublishAgency";
            // 
            // ColumnPublishDate
            // 
            this.ColumnPublishDate.HeaderText = "发布日期";
            this.ColumnPublishDate.Name = "ColumnPublishDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(239, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "School Notice";
            // 
            // infocontent
            // 
            this.infocontent.Location = new System.Drawing.Point(29, 95);
            this.infocontent.Name = "infocontent";
            this.infocontent.Size = new System.Drawing.Size(924, 414);
            this.infocontent.TabIndex = 3;
            this.infocontent.Text = "";
            // 
            // QueryNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.infocontent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewNotifocation);
            this.Controls.Add(this.label1);
            this.Name = "QueryNotification";
            this.Text = "QueryNotification";
            this.Load += new System.EventHandler(this.InquiryNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotifocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewNotifocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPublishAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPublishDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox infocontent;
    }
}