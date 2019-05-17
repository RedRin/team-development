using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;

namespace team_development.UI.QueryMealCard
{
    public partial class QueryMealcard : Form
    {
        Geticas getIcas = Geticas.Icas;
        public QueryMealcard()
        {
            InitializeComponent();
        }

        private void MealcardInquiry_Load(object sender, EventArgs e)
        {

        }

        private void query_Click(object sender, EventArgs e)
        {
            try
            {
                HtmlDocument html = getIcas.Login("2016052351", "104213");
                //htmlcontent.Text=html.Body.InnerHtml;
            }
            catch(Exception)
            {
                MessageBox.Show("登陆失败,请确认数字暨大用户名和密码");
            }
        }

        private void realquery_Click(object sender, EventArgs e)
        {

        }
        private void QueryMealCard() {
            try
            {
                String str = getIcas.Query();

                str = str.Substring(str.IndexOf("更换头像"));
                str = str.Substring(str.IndexOf("t01>"));
                textBox2.Text = str.Substring(str.IndexOf("t01>") + 4, str.IndexOf("</S") - str.IndexOf("t01>") - 4);
                str = str.Substring(str.IndexOf("t02>"));
                textBox1.Text = str.Substring(str.IndexOf("t02>") + 4, str.IndexOf("</S") - str.IndexOf("t02>") - 4);
                str = str.Substring(str.IndexOf("余额"));
                textBox3.Text = str.Substring(str.IndexOf("nt>") + 3, str.IndexOf("</S") - str.IndexOf("nt>") - 3);
                str = str.Substring(str.IndexOf("<FONT class=green>"));
                textBox4.Text = str.Substring(str.IndexOf("reen>") + 5, str.IndexOf("/F") - str.IndexOf("reen>") - 6);
            }
            catch (Exception)
            {
                MessageBox.Show("查询失败，请稍后再试");
            }
           }
        private void QueryMealcard_Load(object sender, EventArgs e)
        {

        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            QueryMealCard();
        }
    }
}
