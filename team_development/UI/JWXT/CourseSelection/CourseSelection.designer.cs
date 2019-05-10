namespace team_development.UI.CourseSelection
{
    partial class CourseSelection
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
            this.TimingSelection = new System.Windows.Forms.Button();
            this.Selection = new System.Windows.Forms.Button();
            this.CourseInfo = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // TimingSelection
            // 
            this.TimingSelection.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimingSelection.Location = new System.Drawing.Point(710, 479);
            this.TimingSelection.Name = "TimingSelection";
            this.TimingSelection.Size = new System.Drawing.Size(119, 32);
            this.TimingSelection.TabIndex = 2;
            this.TimingSelection.Text = "定时选课";
            this.TimingSelection.UseVisualStyleBackColor = true;
            this.TimingSelection.Click += new System.EventHandler(this.TimingSelection_Click);
            // 
            // Selection
            // 
            this.Selection.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Selection.Location = new System.Drawing.Point(846, 479);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(119, 32);
            this.Selection.TabIndex = 3;
            this.Selection.Text = "立即选课";
            this.Selection.UseVisualStyleBackColor = true;
            this.Selection.Click += new System.EventHandler(this.Selection_Click);
            // 
            // CourseInfo
            // 
            this.CourseInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CourseInfo.Location = new System.Drawing.Point(86, 27);
            this.CourseInfo.Name = "CourseInfo";
            this.CourseInfo.Size = new System.Drawing.Size(879, 439);
            this.CourseInfo.TabIndex = 4;
            this.CourseInfo.UseCompatibleStateImageBehavior = false;
            this.CourseInfo.SelectedIndexChanged += new System.EventHandler(this.CourseInfo_SelectedIndexChanged);
            // 
            // CourseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.CourseInfo);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.TimingSelection);
            this.Name = "CourseSelection";
            this.Text = "course_selection";
            this.Load += new System.EventHandler(this.Course_selection_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TimingSelection;
        private System.Windows.Forms.Button Selection;
        private System.Windows.Forms.ListView CourseInfo;
    }

}