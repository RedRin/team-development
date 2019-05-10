using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib.GetJWXT;
using Lib;

namespace team_development.UI.QueryGPA
{
    public partial class QueryMark : Form
    {
        Lib.GetJWXT.GetJWXT jwxt = new Lib.GetJWXT.GetJWXT();
        public List<Gpa> Gpas = new List<Gpa>();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private bool isGet = false;
        public QueryMark()
        {
            InitializeComponent();
            choose_semester.SelectedIndex = 0;
            choose_academic_year.SelectedIndex = 0;
            TableLoad();
            timer.Interval = 3000;
            timer.Tick += new EventHandler(timerTick);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            if (jwxt.GetStatus()&& !isGet )
            {
                SetGpa();
                isGet = true;
            }
            else if (!isGet){
                jwxt.Login("2016052351", "liangzp1818");
            }
        }

        public void TableLoad()
        {
            show_gpa.GridLines = true;

            show_gpa.View = View.Details;
            show_gpa.Scrollable = true;
            
            this.show_gpa.Columns.Add("学年", 90, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("学期", 60, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程名称", 150, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("学分", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("成绩", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("绩点", 80, HorizontalAlignment.Center);
            this.show_gpa.Columns.Add("课程类别", 90, HorizontalAlignment.Center);
        }

        private void GpaInquiry_Load(object sender, EventArgs e)
        {
           
        }

        private void Show_gpa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void validate_Click(object sender, EventArgs e)
        {
            ShowValidate.Image = jwxt.GetValidateImage();
        }

        private void login_Click(object sender, EventArgs e)
        {
            jwxt.Login("2016052351", "liangzp1818");
            Log.log.Info("CLICK LOGIN_BUTTON IN QueryGPA");
            
        }

        private void SetGpa()
        {
            HtmlDocument GpaDoc = jwxt.GetGPA();
            show_gpa.Clear();
            TableLoad();

            string str = (string)GpaDoc.Body.InnerHtml;
            string itemlist=null;
            List<Gpa> Gpas;
            Gpas = jwxt.GetGpaList(str);

            foreach (Gpa g in Gpas)
            {
                itemlist += g.mark + "\r\n";

            }
            ListViewItem temp=new ListViewItem();
            int flag = 0;
            if (choose_academic_year.Text !="ALL")
                flag++;
            if (choose_semester.Text != "ALL")
                flag+=2;

            this.show_gpa.BeginUpdate();
            switch (flag) {
                case 0:
                    foreach (Gpa g in Gpas)
                    {
                        ShowGpa(temp, g);
                    }
                    break;
                case 1:
                    foreach (Gpa g in Gpas)
                    {
                        if (g.schoolyear == choose_academic_year.Text)
                        {
                            ShowGpa(temp, g);
                        }
                    }
                    break;
                case 2:
                    foreach (Gpa g in Gpas)
                    {
                        if (g.semester==choose_semester.Text)
                        {
                            ShowGpa(temp, g);
                        }
                    }
                    break;
                case 3:
                    foreach (Gpa g in Gpas)
                    {
                        if ((g.schoolyear == choose_academic_year.Text)&& 
                            (g.semester == choose_semester.Text))
                        {
                            ShowGpa(temp, g);
                        }
                    }
                    break;
                default:
                    MessageBox.Show("switch error");
                    break;
            }//end of switch
            this.show_gpa.EndUpdate();
        }
        public void ShowGpa(ListViewItem temp,Gpa g) {
            temp = new ListViewItem();
            temp.Text = g.schoolyear;
            temp.SubItems.Add(g.semester);
            temp.SubItems.Add(g.coursename);
            temp.SubItems.Add(g.credit.ToString());
            temp.SubItems.Add(g.mark.ToString());
            temp.SubItems.Add(g.gp.ToString());
            temp.SubItems.Add(g.coursecategory);
            this.show_gpa.Items.Add(temp);
        }
    }
}