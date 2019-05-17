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
using Lib.GetJWXT;

namespace team_development.UI.CourseSelection
{
    public partial class CourseSelection : Form
    {
        public CourseSelection()
        {
            InitializeComponent();
            TableLoad();
            GetCourse();
            Console.WriteLine(this.CourseInfo.Items[0]);
        }

        private void Course_selection_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“visual_studioDataSet.course”中。您可以根据需要移动或删除它。


        }

        private void QueryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void AFLToolStripMenuItem_Click(object sender, EventArgs e)// ask for leave
        {

        }

        private void TimingSelection_Click(object sender, EventArgs e)
        {
            Form ts = new TimeSetting();
            Log.log.Info("Click TimeSelection Button In CourseSelection Form.");
            ts.ShowDialog();
        }


        private void CourseInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Selection_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click Selection button In CourseSelection Form.");
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult dlr = MessageBox.Show("确认选课？", "", btn);
            if (dlr == DialogResult.OK)
            {
                Log.log.Debug("dlr == DialogResult.OK - select courses successfully.");
                dlr = MessageBox.Show("选课成功", "", btn);
            }
            else {
                Log.log.Debug("dlr != DialogResult.OK - select courses successfully.");
            }
        }

        private void TableLoad() {
            Log.log.Info("CALL TableLoad function.");

            this.CourseInfo.GridLines = true;

            this.CourseInfo.View = View.Details;
            this.CourseInfo.Scrollable = true;

            this.CourseInfo.Columns.Add("班号", 90, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("课程编号", 70, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("课程", 150, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("学分", 50, HorizontalAlignment.Center);
            //this.CourseInfo.Columns.Add("修学", 50, HorizontalAlignment.Center);
            //this.CourseInfo.Columns.Add("类别", 50, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("时间安排", 82, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("教师", 50, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("上课地点", 90, HorizontalAlignment.Center);
            this.CourseInfo.Columns.Add("备注", 70, HorizontalAlignment.Center);
            //this.CourseInfo.Columns.Add("考试时间", 82, HorizontalAlignment.Center);
            //this.CourseInfo.Columns.Add("阶段", 50, HorizontalAlignment.Center);
            //this.CourseInfo.Columns.Add("状态", 50, HorizontalAlignment.Center);
        }

        private void CourseInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void GetCourse() {
            Log.log.Info("CALL GetCourse function.");
            string path = System.AppContext.BaseDirectory.Substring(0, System.AppContext.BaseDirectory.LastIndexOf(@"\team_development")) + @"\Libary\CourseFile\course.txt";
            string json = System.IO.File.ReadAllText(path, Encoding.Default);
            string value;
            string[] list = new string[15];

            for (int j = 0; j < 15; j++)
            {
                GetValue.GetValue1(json, j, out value);
                list[j] = value;
            }

            for (int k = 0; k < 15; k++)
            {
                List<string> test = new List<string>();

                string[] t = list[k].Split('"', ',', '[', ']');
                foreach (string i in t)
                    test.Add(i.ToString());




                List<string> list1 = new List<string>();
                foreach (string s in test.ToArray())
                {
                    if (!string.IsNullOrEmpty(s))
                    {
                        list1.Add(s);
                    }
                }

                test = list1;

                for (int i = 0; i < test.ToArray().Length; i++)
                {
                    Console.WriteLine(test[i]);
                }


                List<Course> Courses = new List<Course>();

                string classnumber = test[9];
                string coursenumber = test[0];
                string coursename = test[1];
                string credit = test[6];
                string type = "";
                string category = "";
                string time = test[8];
                string teachername = test[4];
                string location = test[7];
                string ps = test[12];
                string testtime = "";

                Course course = new Course(classnumber, coursenumber, coursename, credit, type, category, time, teachername, location,
    ps, testtime);
                Courses.Add(course);
                ListViewItem temp = new ListViewItem();
                this.CourseInfo.BeginUpdate();
                ShowCourse(temp, course);
                this.CourseInfo.EndUpdate();
            }
        }

        public void ShowCourse(ListViewItem temp, Course c)
        {
            temp = new ListViewItem();
            temp.Text = c.classnumber;
            temp.SubItems.Add(c.coursenumber);
            temp.SubItems.Add(c.coursename);
            temp.SubItems.Add(c.credit);
            //temp.SubItems.Add(c.type);
            //temp.SubItems.Add(c.category);
            temp.SubItems.Add(c.time);
            temp.SubItems.Add(c.teachername);
            temp.SubItems.Add(c.location);
            temp.SubItems.Add(c.ps);
            //temp.SubItems.Add(c.testtime);
            this.CourseInfo.Items.Add(temp);
        }
    }
}
