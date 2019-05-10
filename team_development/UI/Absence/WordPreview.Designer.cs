namespace team_development.UI.Absence
{
    partial class WordPreview
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ContentBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.Cancel.Location = new System.Drawing.Point(799, 575);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(134, 38);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.Save.Location = new System.Drawing.Point(952, 575);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(134, 38);
            this.Save.TabIndex = 3;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(97, 32);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(989, 527);
            this.ContentBox.TabIndex = 4;
            this.ContentBox.Text = "";
            // 
            // WordPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 682);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WordPreview";
            this.Text = "预览word文档";
            this.Load += new System.EventHandler(this.WordPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.RichTextBox ContentBox;
    }
}