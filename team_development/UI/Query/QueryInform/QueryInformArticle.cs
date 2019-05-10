using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.QueryInform
{
    public partial class QueryInformArticle : Form
    {
        public QueryInformArticle()
        {
            InitializeComponent();
            textBox1.Text += "  \r\n暨南大学党政办公室关于2019年清明节放假的通知\r\n";
            textBox1.Text += "  发布单位：党政办公室 [2019-03-15 16:00:09] 打印此信息\r\n\r\n";
            textBox1.Text += "  校机关各部、处、院、室、中心，各直属单位，各学院，各校区管理委员会:\r\n\r\n";
            textBox1.Text += "  根据《国务院办公厅关于2019年部分节假日安排的通知》（国办发明电〔2018〕15号），" +
                                "2019年清明节4月5日放假，与周末连休，共3天。\r\n\r\n";
            textBox1.Text += "  请各单位登录学校门户，网上填报假期值班表。（详见附件)\r\n\r\n";

            textBox1.Text += "  不能停止生产和工作的单位，放假办法由各单位自行安排。节假日期间，各部门要妥善安排好值班和安全、保卫等工作，" +
                                 "遇有重大突发事件发生，要按规定及时报告并妥善处置，确保广大师生祥和平安度过节日假期。\r\n\r\n";

            textBox1.Text += "  特此通知\r\n\r\n\r\n\r\n";

            textBox1.Text += "  附件：网上填报值班表流程\r\n\r\n\r\n";

            textBox1.Text += "  党政办公室\r\n";

            textBox1.Text += "  2019年3月15日\r\n";
        }

        private void NotificationArticle_Load(object sender, EventArgs e)
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
            TurnToForm(new QueryNotification());
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
