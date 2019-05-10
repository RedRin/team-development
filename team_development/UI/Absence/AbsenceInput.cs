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
    public partial class AbsenceInput : Form
    {
        public AbsenceInput()
        {
            InitializeComponent();
        }

        private void Absence_Load(object sender, EventArgs e)
        {
            Log.log.Info("Loading AbsenceInput Form.");
            this.SelectedTemplate.Text = AbsenceWordManager.GetSelectedTemplateName();

            this.StuName.Text = AbsenceWordManager.FromName;
            this.StuNumber.Text = AbsenceWordManager.StudentNum;
            this.Department.Text = AbsenceWordManager.Department;
            this.PhoneNumber.Text = AbsenceWordManager.Phone;
            this.ToName.Text = AbsenceWordManager.ToName;
            this.Reason.Text = AbsenceWordManager.Reason;


            this.StartTime.Value = AbsenceWordManager.StartTime;
            this.EndTime.Value = AbsenceWordManager.EndTime;
        }

        private void SelectTemplate_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click SelectTemplate Button In AbsenceInput Form");
            //填写请假条 -> 选择模板
            TurnToForm(new TemplateSelect());

        }

        private void WordPreview_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click WordPreview Button In AbsenceInput Form");
            //填写请假条 -> word预览
            TurnToForm(new WordPreview());
        }

        private void TurnToForm(Form f)
        {
            ((Form1)(this.ParentForm)).TurnForm(f);
        }

        private void StartTime_ValueChanged(object sender, EventArgs e)
        {
            AbsenceWordManager.StartTime = this.StartTime.Value;
        }

        private void EndTime_ValueChanged(object sender, EventArgs e)
        {
            AbsenceWordManager.EndTime = this.EndTime.Value;
        }


        private void StuNumber_TextChanged(object sender, EventArgs e)
        {
            AbsenceWordManager.StudentNum = this.StuNumber.Text;
        }

        private void StuName_TextChanged(object sender, EventArgs e)
        {
            AbsenceWordManager.FromName = this.StuName.Text;
        }

        private void Department_TextChanged(object sender, EventArgs e)
        {
            AbsenceWordManager.Department = this.Department.Text;
        }

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            AbsenceWordManager.Phone = this.PhoneNumber.Text;
        }

        private void ToName_TextChanged(object sender, EventArgs e)
        {
            AbsenceWordManager.ToName = this.ToName.Text;
        }

        private void Reason_TextChanged(object sender, EventArgs e)
        {
            AbsenceWordManager.Reason = this.Reason.Text;
        }
    }
}
