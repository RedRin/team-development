namespace team_development.UI.CourseSelection
{
    partial class TimeSetting
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
            this.YearListBox = new System.Windows.Forms.ListBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MonthListBox = new System.Windows.Forms.ListBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.DayLabel = new System.Windows.Forms.Label();
            this.DayListBox = new System.Windows.Forms.ListBox();
            this.HourListBox = new System.Windows.Forms.ListBox();
            this.HourLabel = new System.Windows.Forms.Label();
            this.MinuteListBox = new System.Windows.Forms.ListBox();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.SecondListBox = new System.Windows.Forms.ListBox();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YearListBox
            // 
            this.YearListBox.FormattingEnabled = true;
            this.YearListBox.ItemHeight = 15;
            this.YearListBox.Location = new System.Drawing.Point(38, 63);
            this.YearListBox.Name = "YearListBox";
            this.YearListBox.Size = new System.Drawing.Size(41, 34);
            this.YearListBox.TabIndex = 0;
            this.YearListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.YearLabel.Location = new System.Drawing.Point(85, 63);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(31, 25);
            this.YearLabel.TabIndex = 1;
            this.YearLabel.Text = "年";
            // 
            // MonthListBox
            // 
            this.MonthListBox.FormattingEnabled = true;
            this.MonthListBox.ItemHeight = 15;
            this.MonthListBox.Location = new System.Drawing.Point(112, 63);
            this.MonthListBox.Name = "MonthListBox";
            this.MonthListBox.Size = new System.Drawing.Size(41, 34);
            this.MonthListBox.TabIndex = 2;
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MonthLabel.Location = new System.Drawing.Point(159, 63);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(31, 25);
            this.MonthLabel.TabIndex = 3;
            this.MonthLabel.Text = "月";
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DayLabel.Location = new System.Drawing.Point(234, 63);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(31, 25);
            this.DayLabel.TabIndex = 4;
            this.DayLabel.Text = "日";
            // 
            // DayListBox
            // 
            this.DayListBox.FormattingEnabled = true;
            this.DayListBox.ItemHeight = 15;
            this.DayListBox.Location = new System.Drawing.Point(187, 63);
            this.DayListBox.Name = "DayListBox";
            this.DayListBox.Size = new System.Drawing.Size(41, 34);
            this.DayListBox.TabIndex = 5;
            // 
            // HourListBox
            // 
            this.HourListBox.FormattingEnabled = true;
            this.HourListBox.ItemHeight = 15;
            this.HourListBox.Location = new System.Drawing.Point(260, 63);
            this.HourListBox.Name = "HourListBox";
            this.HourListBox.Size = new System.Drawing.Size(41, 34);
            this.HourListBox.TabIndex = 6;
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HourLabel.Location = new System.Drawing.Point(307, 63);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(31, 25);
            this.HourLabel.TabIndex = 7;
            this.HourLabel.Text = "时";
            // 
            // MinuteListBox
            // 
            this.MinuteListBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinuteListBox.FormattingEnabled = true;
            this.MinuteListBox.ItemHeight = 15;
            this.MinuteListBox.Location = new System.Drawing.Point(332, 63);
            this.MinuteListBox.Name = "MinuteListBox";
            this.MinuteListBox.Size = new System.Drawing.Size(41, 34);
            this.MinuteListBox.TabIndex = 8;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.AutoSize = true;
            this.MinuteLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinuteLabel.Location = new System.Drawing.Point(379, 63);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(31, 25);
            this.MinuteLabel.TabIndex = 9;
            this.MinuteLabel.Text = "分";
            // 
            // SecondListBox
            // 
            this.SecondListBox.FormattingEnabled = true;
            this.SecondListBox.ItemHeight = 15;
            this.SecondListBox.Location = new System.Drawing.Point(407, 63);
            this.SecondListBox.Name = "SecondListBox";
            this.SecondListBox.Size = new System.Drawing.Size(41, 34);
            this.SecondListBox.TabIndex = 10;
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SecondLabel.Location = new System.Drawing.Point(455, 63);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(31, 25);
            this.SecondLabel.TabIndex = 11;
            this.SecondLabel.Text = "秒";
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OKButton.Location = new System.Drawing.Point(90, 163);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(128, 34);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "确认";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelButton.Location = new System.Drawing.Point(282, 163);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(128, 34);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TimeSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 262);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.SecondListBox);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.MinuteListBox);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.HourListBox);
            this.Controls.Add(this.DayListBox);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.MonthListBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.YearListBox);
            this.Name = "TimeSetting";
            this.Text = "SettingTime";
            this.Load += new System.EventHandler(this.TimeSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox YearListBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.ListBox MonthListBox;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.ListBox DayListBox;
        private System.Windows.Forms.ListBox HourListBox;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.ListBox MinuteListBox;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.ListBox SecondListBox;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}