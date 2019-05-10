using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.QueryEmploy
{
    public partial class OfferArticle : Form
    {
        public OfferArticle()
        {
            InitializeComponent();
            textBoxOffer1.Text += "  \r\n12-24万 \r\n";
            textBoxOffer1.Text += "  杭州 2019-03-12\r\n\r\n";
            textBoxOffer2.Text += "大专及以上 语言不限 年龄不限\r\n\r\n";
            textBoxOffer2.Text += "职位描述：\r\n";
            textBoxOffer2.Text += "职位描述：\r\n";
            textBoxOffer2.Text += "1、从销售前端部门收集客户基础信息，分析客户人才画像并制定销售策略；\r\n";
            textBoxOffer2.Text += "2、根据客户实际情况选择到店洽谈或者上门服务，配合设计师量房、出设计方案、谈单促成合同签订；\r\n";
            textBoxOffer2.Text += "3、协调供应链和工程交付部门，完成选材、配送和施工交付，并且维护好客户关系，让客户推荐回单。\r\n";
            textBoxOffer2.Text += "任职资格：\r\n";
            textBoxOffer2.Text += "1、统招大专以上学历，专业不限，一年以上销售工作经验；\r\n";
            textBoxOffer2.Text += "2、具有销售意识与销售技巧，一定的目标计划实施能力；\r\n";
            textBoxOffer2.Text += "3、具备沟通能力、洞察力、学习能力、计划力、执行力、抗压能力、领导力、追求卓越。\r\n";
            textBoxOffer2.Text += "享受生日福利、节假日福利、团建经费和外出旅游活动。\r\n";
            textBoxOffer2.Text += "晋升发展：\r\n";
            textBoxOffer2.Text += "客户经理——销售主管/经理——门店店长\r\n";
        }

        private void OfferArticle_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)
        {
            TurnToForm(new QueryEmploy());           
        }
        private void TurnToForm(Form f)
        {
            //TODO 会不会出现null的情况
            Panel parent = (Panel)this.Parent;
            parent.Controls.Clear();

            //Form templateSelect = new TemplateSelect();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = System.Windows.Forms.DockStyle.Fill;

            parent.Controls.Add(f);
            f.Show();
        }
    }
}