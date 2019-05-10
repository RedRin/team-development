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
    public partial class QueryNotification : Form
    {
        public Form1 form1;
        public QueryNotification()
        {
            InitializeComponent();          
            DataGridViewRowCollection rows = dataGridViewNotifocation.Rows;
            rows.Add(new object[] { "暨南大学党政办公室关于2019年“五一”国际劳动节放假的通知", "党政办公室", "2019 - 04 - 15" });
            rows.Add(new object[] { "关于启动暨南大学首次五级、六级职员聘任工作的通知", "人力资源开发与管理处", "2019 - 04 - 03" });
            rows.Add(new object[] { "关于开展第十五届广东省丁颖科技奖推荐评选工作的通知", "人力资源开发与管理处", "2019 - 04 - 19" });
            rows.Add(new object[] { "关于申报霍英东教育基金会2019年高等院校青年教师基金（文科类）的通知", "社会科学研究处", "2019 - 04 - 19" });
            rows.Add(new object[] { "关于电子邮箱系统升级及核对邮箱账号信息的通知", "网络与教育技术中心", "2019 - 03 - 12" });
            rows.Add(new object[] { "暨南大学关于开展第六届“本科教学校长奖”评选工作的通知", "教务处", "2019 - 01 - 10" });
            rows.Add(new object[] { "关于个税专项附加扣除信息采集相关事项的通知", "财务与国有资产管理处", "2019 - 01 - 09" });
            rows.Add(new object[] { "关于启动暨南大学七级、八级职员聘任工作的通知", "人力资源开发与管理处", "2018 - 12 - 29" });
            rows.Add(new object[] { "关于升级电子邮箱系统的通知", "网络与教育技术中心", "2019 - 03 - 29" });
            rows.Add(new object[] { "关于参加第十届中外合作办学年会第二次筹备会议的通知", "国际交流合作处（港澳台侨事务办公室)", "2019 - 03 - 29" });
        }
        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RIndex = e.RowIndex;
            int CIndex = e.ColumnIndex;
            if (RIndex == 0&& CIndex == 0)
            {
                TurnToForm(new QueryInformArticle());   
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InquiryNotification_Load(object sender, EventArgs e)
        {
           
        }
        private void TurnToForm(Form f)
        {
            //TODO 会不会出现null的情况
            ((Form1)(this.ParentForm)).TurnForm(f);
        }
    }
}
