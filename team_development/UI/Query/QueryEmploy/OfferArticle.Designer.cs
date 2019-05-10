namespace team_development.UI.QueryEmploy
{
    partial class OfferArticle
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
            this.textBoxOffer1 = new System.Windows.Forms.TextBox();
            this.textBoxOffer2 = new System.Windows.Forms.TextBox();
            this.buttonOffer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOffer1
            // 
            this.textBoxOffer1.Font = new System.Drawing.Font("宋体", 24F);
            this.textBoxOffer1.Location = new System.Drawing.Point(3, -2);
            this.textBoxOffer1.Multiline = true;
            this.textBoxOffer1.Name = "textBoxOffer1";
            this.textBoxOffer1.ReadOnly = true;
            this.textBoxOffer1.Size = new System.Drawing.Size(1050, 177);
            this.textBoxOffer1.TabIndex = 0;
            // 
            // textBoxOffer2
            // 
            this.textBoxOffer2.Font = new System.Drawing.Font("宋体", 13F);
            this.textBoxOffer2.Location = new System.Drawing.Point(3, 172);
            this.textBoxOffer2.Multiline = true;
            this.textBoxOffer2.Name = "textBoxOffer2";
            this.textBoxOffer2.ReadOnly = true;
            this.textBoxOffer2.Size = new System.Drawing.Size(1050, 347);
            this.textBoxOffer2.TabIndex = 1;
            this.textBoxOffer2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // buttonOffer
            // 
            this.buttonOffer.Location = new System.Drawing.Point(463, 525);
            this.buttonOffer.Name = "buttonOffer";
            this.buttonOffer.Size = new System.Drawing.Size(88, 29);
            this.buttonOffer.TabIndex = 2;
            this.buttonOffer.Text = "返回";
            this.buttonOffer.UseVisualStyleBackColor = true;
            this.buttonOffer.Click += new System.EventHandler(this.button1_Click);
            // 
            // OfferArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 568);
            this.Controls.Add(this.buttonOffer);
            this.Controls.Add(this.textBoxOffer2);
            this.Controls.Add(this.textBoxOffer1);
            this.Name = "OfferArticle";
            this.Text = "OfferArticle";
            this.Load += new System.EventHandler(this.OfferArticle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOffer1;
        private System.Windows.Forms.TextBox textBoxOffer2;
        private System.Windows.Forms.Button buttonOffer;
    }
}