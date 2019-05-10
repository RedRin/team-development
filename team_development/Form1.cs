using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using team_development.FormLib;
using team_development.UI.UserInfo;

namespace team_development
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //UserInfo u = new UserInfo();
           // u=(UserInfo)Storage.Load("UserInfo.xml");
        }

        private void CourseSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.log.Info("CLICK Menu CourseSelection.");
            TurnForm(MenuType.JWXT, SubMenuType.CourseSelection);
        }


        private void Form1Content_Paint(object sender, PaintEventArgs e)
        {

        }


        private void UserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.log.Info("CLICK SubMenu UserInfo.");
            TurnForm(MenuType.UserInfo);
        }
        public void TurnForm(MenuType MenuId,SubMenuType SubMenu=0)
        {
            if (SubMenu!=0)
            {
                Log.log.InfoFormat("LOADING Form of Menu {0},SubMenu {1}", MenuId, SubMenu);
            }
            else {
                Log.log.InfoFormat("LOADING Form of Menu {0},SubMenu {1}", MenuId);
            }
            TurnForm(MenuGetter.GetMenu(MenuId, SubMenu));
        }
        public void TurnForm(Form PannelForm) {
            PannelForm.TopLevel = false;
            PannelForm.FormBorderStyle = FormBorderStyle.None;
            PannelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form1Content.Controls.Clear();
            this.Form1Content.Controls.Add(PannelForm);
            PannelForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AbsenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.log.Info("CLICK Menu AbsenceTool.");
            TurnForm(MenuType.Absence);
        }

        private void QueryEmployToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.log.Info("CLICK SubMenu QueryEmploy.");
            TurnForm(MenuType.Query, SubMenuType.QueryEmploy);
        }

        private void QueryInformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.log.Info("CLICK SubMenu QueryInform.");
            TurnForm(MenuType.Query, SubMenuType.QueryInform);
        }

        private void QueryCostToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Log.log.Info("CLICK SubMenu QueryCost.");
            TurnForm(MenuType.Query, SubMenuType.QueryCost);
            
        }

        private void MatchSchemeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Log.log.Info("CLICK Menu MatchScheme.");
            TurnForm(MenuType.JWXT, SubMenuType.MatchScheme);
        }
        private void QuiryGpaToolStripMenuItem_Click(object sender, EventArgs e) {
            Log.log.Info("CLICK SubMenu QueryGpa.");
            TurnForm(MenuType.Query, SubMenuType.QueryMark);
        }
        private void QuiryMealCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.log.Info("CLICK SubMenu QueryMealCard.");
            TurnForm(MenuType.Query, SubMenuType.QueryMealCard);
        }

        private void QueryForumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.log.Info("CLICK Menu QueryForum.");
            TurnForm(MenuType.Forum);
            //System.Diagnostics.Process.Start("explorer.exe", "http://www.ijnu.cn/");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Log.log.Info("CLICK Search Button.");
            TurnForm(MenuType.Search);
        }
    }
}
