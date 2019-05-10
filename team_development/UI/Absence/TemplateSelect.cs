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

namespace team_development.UI.Absence
{
    public partial class TemplateSelect : Form
    {

        public TemplateSelect()
        {
            InitializeComponent();
            UpdateList(AbsenceWordManager.GetWordTemplateList(AbsenceWordManager.DefaultTempalteDir));
        }

        private void TurnToForm(Form f)
        {
            Log.log.Info("Call TurnToForm Function");
            Panel parent = (Panel)this.Parent;
            if(parent == null)
            {
                Log.log.Error("Panel Widget Is Null In Function TurnToForm In TemplateSelect Form");
                return;
            }
            parent.Controls.Clear();

            //Form templateSelect = new TemplateSelect();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = System.Windows.Forms.DockStyle.Fill;

            parent.Controls.Add(f);
            f.Show();
        }

        private void TemplatePreview_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Preview Button In TemplateSelect Form.");
            //选择模板 -> 预览模板
            TurnToForm(new TemplatePreview());
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Confirm Button In TemplateSelect Form.");
            //选择模板 -> 填写请假条
            AbsenceWordManager.SelectedIndex = AbsenceWordManager.OldSelectedIndex;
            TurnToForm(new AbsenceInput());
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Cancel Button In TemplateSelect Form.");
            // 选择模板->填写请假条
            TurnToForm(new AbsenceInput());
        }

        private void TemplateSelect_Load(object sender, EventArgs e)
        {
            Log.log.Info("Loading TemplateSelect Function");

            UpdateList(AbsenceWordManager.GetNowTemplateNames());
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Update Button In TemplateSelect Form.");
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "选择模板文件夹";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string templateDir = dialog.SelectedPath;  //选中的文件夹的路径
                AbsenceWordManager.DefaultTempalteDir = templateDir;

                List<string> templates = AbsenceWordManager.GetWordTemplateList(templateDir);
                UpdateList(templates);
            }
        }
        

        private void TemplateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Log.log.Info("Select ListBox Item In TemplateSelect.");
            //TODO: 取消时回退
            AbsenceWordManager.OldSelectedIndex = TemplateList.SelectedIndex;
        }

        private void UpdateList(List<string> templateNames)
        {
            this.TemplateList.Items.Clear();
            foreach (string fileName in templateNames)
            {
                this.TemplateList.Items.Add(fileName);
            }
        }
    }
}
