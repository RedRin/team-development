namespace team_development.UI.Absence
{
    partial class AbsenceInput
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
            this.SelectedTemplate = new System.Windows.Forms.TextBox();
            this.SelectTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StuName = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StuNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ToName = new System.Windows.Forms.TextBox();
            this.Reason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WordPreview = new System.Windows.Forms.Button();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // SelectedTemplate
            // 
            this.SelectedTemplate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectedTemplate.Location = new System.Drawing.Point(111, 73);
            this.SelectedTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectedTemplate.Name = "SelectedTemplate";
            this.SelectedTemplate.Size = new System.Drawing.Size(828, 31);
            this.SelectedTemplate.TabIndex = 0;
            this.SelectedTemplate.Text = "未实现";
            // 
            // SelectTemplate
            // 
            this.SelectTemplate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.SelectTemplate.Location = new System.Drawing.Point(946, 67);
            this.SelectTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectTemplate.Name = "SelectTemplate";
            this.SelectTemplate.Size = new System.Drawing.Size(141, 42);
            this.SelectTemplate.TabIndex = 1;
            this.SelectTemplate.Text = "浏览模板";
            this.SelectTemplate.UseVisualStyleBackColor = true;
            this.SelectTemplate.Click += new System.EventHandler(this.SelectTemplate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label1.Location = new System.Drawing.Point(108, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号";
            // 
            // StuName
            // 
            this.StuName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuName.Location = new System.Drawing.Point(238, 194);
            this.StuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StuName.Name = "StuName";
            this.StuName.Size = new System.Drawing.Size(398, 31);
            this.StuName.TabIndex = 3;
            this.StuName.Text = "请假人姓名";
            this.StuName.TextChanged += new System.EventHandler(this.StuName_TextChanged);
            // 
            // Department
            // 
            this.Department.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Department.Location = new System.Drawing.Point(238, 248);
            this.Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(398, 31);
            this.Department.TabIndex = 7;
            this.Department.Text = "请假人院系";
            this.Department.TextChanged += new System.EventHandler(this.Department_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label3.Location = new System.Drawing.Point(108, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "姓名";
            // 
            // StuNumber
            // 
            this.StuNumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuNumber.Location = new System.Drawing.Point(238, 142);
            this.StuNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StuNumber.Name = "StuNumber";
            this.StuNumber.Size = new System.Drawing.Size(398, 31);
            this.StuNumber.TabIndex = 11;
            this.StuNumber.Text = "请假人学号";
            this.StuNumber.TextChanged += new System.EventHandler(this.StuNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label5.Location = new System.Drawing.Point(108, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "院系";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label7.Location = new System.Drawing.Point(108, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "请假对象";
            // 
            // ToName
            // 
            this.ToName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToName.Location = new System.Drawing.Point(238, 311);
            this.ToName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ToName.Name = "ToName";
            this.ToName.Size = new System.Drawing.Size(848, 31);
            this.ToName.TabIndex = 16;
            this.ToName.Text = "向谁请假，单位名，或是人(如李老师，暨南大学)";
            this.ToName.TextChanged += new System.EventHandler(this.ToName_TextChanged);
            // 
            // Reason
            // 
            this.Reason.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Reason.Location = new System.Drawing.Point(238, 373);
            this.Reason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reason.Multiline = true;
            this.Reason.Name = "Reason";
            this.Reason.Size = new System.Drawing.Size(848, 161);
            this.Reason.TabIndex = 17;
            this.Reason.Text = "请假理由";
            this.Reason.TextChanged += new System.EventHandler(this.Reason_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label8.Location = new System.Drawing.Point(108, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 30);
            this.label8.TabIndex = 18;
            this.label8.Text = "理由";
            // 
            // WordPreview
            // 
            this.WordPreview.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.WordPreview.Location = new System.Drawing.Point(952, 575);
            this.WordPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WordPreview.Name = "WordPreview";
            this.WordPreview.Size = new System.Drawing.Size(134, 38);
            this.WordPreview.TabIndex = 19;
            this.WordPreview.Text = "预览";
            this.WordPreview.UseVisualStyleBackColor = true;
            this.WordPreview.Click += new System.EventHandler(this.WordPreview_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PhoneNumber.Location = new System.Drawing.Point(824, 248);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(262, 31);
            this.PhoneNumber.TabIndex = 25;
            this.PhoneNumber.Text = "138147775";
            this.PhoneNumber.TextChanged += new System.EventHandler(this.PhoneNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label2.Location = new System.Drawing.Point(694, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "手机号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label4.Location = new System.Drawing.Point(694, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "结束时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F);
            this.label6.Location = new System.Drawing.Point(694, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "开始时间";
            // 
            // StartTime
            // 
            this.StartTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartTime.Location = new System.Drawing.Point(824, 142);
            this.StartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(262, 31);
            this.StartTime.TabIndex = 26;
            this.StartTime.ValueChanged += new System.EventHandler(this.StartTime_ValueChanged);
            // 
            // EndTime
            // 
            this.EndTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndTime.Location = new System.Drawing.Point(824, 194);
            this.EndTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(262, 31);
            this.EndTime.TabIndex = 27;
            this.EndTime.ValueChanged += new System.EventHandler(this.EndTime_ValueChanged);
            // 
            // AbsenceInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 682);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WordPreview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Reason);
            this.Controls.Add(this.ToName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StuNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StuName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectTemplate);
            this.Controls.Add(this.SelectedTemplate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AbsenceInput";
            this.Text = "填写请假条";
            this.Load += new System.EventHandler(this.Absence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SelectedTemplate;
        private System.Windows.Forms.Button SelectTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StuName;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StuNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ToName;
        private System.Windows.Forms.TextBox Reason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button WordPreview;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.DateTimePicker EndTime;
    }
}