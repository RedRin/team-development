namespace team_development
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.教务系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MatchSchemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbsenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进入学校论坛ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询通知ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询就业ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询饭卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Form1Content = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.Form1Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.教务系统ToolStripMenuItem,
            this.AbsenceToolStripMenuItem,
            this.进入学校论坛ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.用户信息ToolStripMenuItem,
            this.搜索ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // 教务系统ToolStripMenuItem
            // 
            this.教务系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选课ToolStripMenuItem,
            this.MatchSchemeToolStripMenuItem});
            this.教务系统ToolStripMenuItem.Name = "教务系统ToolStripMenuItem";
            this.教务系统ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.教务系统ToolStripMenuItem.Text = "教务系统";
            // 
            // 选课ToolStripMenuItem
            // 
            this.选课ToolStripMenuItem.Name = "选课ToolStripMenuItem";
            this.选课ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.选课ToolStripMenuItem.Text = "选课";
            this.选课ToolStripMenuItem.Click += new System.EventHandler(this.CourseSelectionToolStripMenuItem_Click);
            // 
            // MatchSchemeToolStripMenuItem
            // 
            this.MatchSchemeToolStripMenuItem.Name = "MatchSchemeToolStripMenuItem";
            this.MatchSchemeToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.MatchSchemeToolStripMenuItem.Text = "查询培养方案";
            this.MatchSchemeToolStripMenuItem.Click += new System.EventHandler(this.MatchSchemeToolStripMenuItem_Click_1);
            // 
            // AbsenceToolStripMenuItem
            // 
            this.AbsenceToolStripMenuItem.Name = "AbsenceToolStripMenuItem";
            this.AbsenceToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.AbsenceToolStripMenuItem.Text = "写请假条";
            this.AbsenceToolStripMenuItem.Click += new System.EventHandler(this.AbsenceToolStripMenuItem_Click);
            // 
            // 进入学校论坛ToolStripMenuItem
            // 
            this.进入学校论坛ToolStripMenuItem.Name = "进入学校论坛ToolStripMenuItem";
            this.进入学校论坛ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.进入学校论坛ToolStripMenuItem.Text = "进入学校论坛";
            this.进入学校论坛ToolStripMenuItem.Click += new System.EventHandler(this.QueryForumToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询成绩ToolStripMenuItem,
            this.查询通知ToolStripMenuItem,
            this.查询就业ToolStripMenuItem,
            this.查询饭卡ToolStripMenuItem,
            this.查询ToolStripMenuItem1});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 查询成绩ToolStripMenuItem
            // 
            this.查询成绩ToolStripMenuItem.Name = "查询成绩ToolStripMenuItem";
            this.查询成绩ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.查询成绩ToolStripMenuItem.Text = "查询成绩";
            this.查询成绩ToolStripMenuItem.Click += new System.EventHandler(this.QuiryGpaToolStripMenuItem_Click);
            // 
            // 查询通知ToolStripMenuItem
            // 
            this.查询通知ToolStripMenuItem.Name = "查询通知ToolStripMenuItem";
            this.查询通知ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.查询通知ToolStripMenuItem.Text = "查询通知";
            this.查询通知ToolStripMenuItem.Click += new System.EventHandler(this.QueryInformToolStripMenuItem_Click);
            // 
            // 查询就业ToolStripMenuItem
            // 
            this.查询就业ToolStripMenuItem.Name = "查询就业ToolStripMenuItem";
            this.查询就业ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.查询就业ToolStripMenuItem.Text = "查询就业";
            this.查询就业ToolStripMenuItem.Click += new System.EventHandler(this.QueryEmployToolStripMenuItem_Click);
            // 
            // 查询饭卡ToolStripMenuItem
            // 
            this.查询饭卡ToolStripMenuItem.Name = "查询饭卡ToolStripMenuItem";
            this.查询饭卡ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.查询饭卡ToolStripMenuItem.Text = "查询饭卡";
            this.查询饭卡ToolStripMenuItem.Click += new System.EventHandler(this.QuiryMealCardToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem1
            // 
            this.查询ToolStripMenuItem1.Name = "查询ToolStripMenuItem1";
            this.查询ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.查询ToolStripMenuItem1.Text = "查询电费";
            this.查询ToolStripMenuItem1.Click += new System.EventHandler(this.QueryCostToolStripMenuItem1_Click);
            // 
            // 用户信息ToolStripMenuItem
            // 
            this.用户信息ToolStripMenuItem.Name = "用户信息ToolStripMenuItem";
            this.用户信息ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.用户信息ToolStripMenuItem.Text = "用户信息";
            this.用户信息ToolStripMenuItem.Click += new System.EventHandler(this.UserInfoToolStripMenuItem_Click);
            // 
            // 搜索ToolStripMenuItem
            // 
            this.搜索ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem";
            this.搜索ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.搜索ToolStripMenuItem.Text = "搜索";
            this.搜索ToolStripMenuItem.Click += new System.EventHandler(this.Search_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // Form1Content
            // 
            this.Form1Content.Controls.Add(this.panel1);
            this.Form1Content.Controls.Add(this.label1);
            this.Form1Content.Location = new System.Drawing.Point(12, 51);
            this.Form1Content.Name = "Form1Content";
            this.Form1Content.Size = new System.Drawing.Size(1072, 569);
            this.Form1Content.TabIndex = 2;
            this.Form1Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1Content_Paint);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(246, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 352);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(219, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "暨南大学学生自助软件";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(884, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 25);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1096, 632);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Form1Content);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Form1Content.ResumeLayout(false);
            this.Form1Content.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 教务系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatchSchemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbsenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进入学校论坛ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询通知ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询就业ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询饭卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 用户信息ToolStripMenuItem;
        private System.Windows.Forms.Panel Form1Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 搜索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

