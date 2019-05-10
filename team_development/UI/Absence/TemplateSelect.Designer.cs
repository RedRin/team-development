namespace team_development.UI.Absence
{
    partial class TemplateSelect
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
            this.SearchLine = new System.Windows.Forms.TextBox();
            this.TemplateList = new System.Windows.Forms.ListBox();
            this.Update = new System.Windows.Forms.Button();
            this.TemplatePreview = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchLine
            // 
            this.SearchLine.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchLine.Location = new System.Drawing.Point(111, 73);
            this.SearchLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchLine.Name = "SearchLine";
            this.SearchLine.Size = new System.Drawing.Size(974, 30);
            this.SearchLine.TabIndex = 1;
            this.SearchLine.Text = "未实现的搜索框";
            // 
            // TemplateList
            // 
            this.TemplateList.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TemplateList.FormattingEnabled = true;
            this.TemplateList.ItemHeight = 24;
            this.TemplateList.Items.AddRange(new object[] {
            "学生标准请假条",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template",
            "Item Template"});
            this.TemplateList.Location = new System.Drawing.Point(111, 181);
            this.TemplateList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TemplateList.Name = "TemplateList";
            this.TemplateList.Size = new System.Drawing.Size(974, 268);
            this.TemplateList.TabIndex = 2;
            this.TemplateList.SelectedIndexChanged += new System.EventHandler(this.TemplateList_SelectedIndexChanged);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.Update.Location = new System.Drawing.Point(441, 575);
            this.Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(186, 41);
            this.Update.TabIndex = 7;
            this.Update.Text = "更新数据库";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // TemplatePreview
            // 
            this.TemplatePreview.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.TemplatePreview.Location = new System.Drawing.Point(646, 575);
            this.TemplatePreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TemplatePreview.Name = "TemplatePreview";
            this.TemplatePreview.Size = new System.Drawing.Size(134, 38);
            this.TemplatePreview.TabIndex = 8;
            this.TemplatePreview.Text = "预览";
            this.TemplatePreview.UseVisualStyleBackColor = true;
            this.TemplatePreview.Click += new System.EventHandler(this.TemplatePreview_Click);
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.Confirm.Location = new System.Drawing.Point(799, 575);
            this.Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(134, 38);
            this.Confirm.TabIndex = 9;
            this.Confirm.Text = "确认";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.Cancel.Location = new System.Drawing.Point(952, 575);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(134, 38);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TemplateSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 682);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.TemplatePreview);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.TemplateList);
            this.Controls.Add(this.SearchLine);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TemplateSelect";
            this.Text = "选择请假条模板";
            this.Load += new System.EventHandler(this.TemplateSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchLine;
        private System.Windows.Forms.ListBox TemplateList;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button TemplatePreview;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
    }
}