using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.Absence
{
    public partial class TemplatePreview : Form
    {
        public TemplatePreview()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Confirm Button In TemplatePreview Form");
            //预览模板 -> 选择模板
            AbsenceWordManager.SelectedIndex = AbsenceWordManager.OldSelectedIndex;
            TurnToForm(new TemplateSelect());
            
        }


        private void TurnToForm(Form f)
        {
            Log.log.Info("Call TurnToForm Function");
            Panel parent = (Panel)this.Parent;
            if(parent == null)
            {
                Log.log.Error("Panel Widget Is Null In Function TurnToForm In TemplatePreview Form");
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Cancel Button In TemplatePreview Form");
            //预览模板 -> 选择模板
            TurnToForm(new TemplateSelect());
        }

        private void TemplatePreview_Load(object sender, EventArgs e)
        {
            Log.log.Info("Loading TemplatePreview Form");

            if(AbsenceWordManager.GetOldSelectedTemplatePath() != "")
            {
                AbsenceWordManager.OpenTemplate(AbsenceWordManager.GetOldSelectedTemplatePath(), ContentBox);
            } else
            {
                MessageBox.Show("未选中模板");
            }
            
        }
    }
}
