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
    public partial class QueryEmploy : Form
    {
        public QueryEmploy()
        {
            InitializeComponent();
            DataGridViewRowCollection rows = dataGridViewOffer.Rows;
            rows.Add(new object[] { "互联网家装销售顾问","12 - 24万", "杭州", "大专及以上" });
            rows.Add(new object[] { "android研发高级工程师", "27 - 54万", "北京", "统招本科" });
            rows.Add(new object[] { "高级JAVA开发工程师", "22 - 34万", "上海", "统招本科" });
            rows.Add(new object[] { "iOS开发工程师 - 微博", "28 - 56万", "北京", "统招本科" });
            rows.Add(new object[] { "高级python开发工程师", "18 - 36万", "北京", "统招本科" });
            rows.Add(new object[] { "少儿编程讲师（scratch /Python/C++）", "18 - 36万", "南京", "统招本科" });
            rows.Add(new object[] { "数据分析师（经营管理）", "10 - 20万", "深圳", "统招本科" });
            rows.Add(new object[] { "金融数据分析师", "10 - 18万", "深圳", "统招本科" });
            rows.Add(new object[] { "大数据架构师/专家", "60 - 74万", "深圳", "硕士" });
            rows.Add(new object[] { "C#高级工程师", "10 - 16万", "北京", "统招本科" });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RIndex = e.RowIndex;
            int CIndex = e.ColumnIndex;
            if (RIndex == 0 && CIndex == 0)
            {
                TurnToForm(new OfferArticle());
            }
        }
        private void TurnToForm(Form f)
        {
            //TODO 会不会出现null的情况
            ((Form1)(this.ParentForm)).TurnForm(f);
        }

        private void InquiryOffer_Load(object sender, EventArgs e)
        {

        }
    }
}
