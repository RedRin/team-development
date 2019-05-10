using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Lib
{
    public class AbsenceWordManager
    {
        public static List<string> TemplatesFilePath = new List<string>();
        public static int SelectedIndex = -1;
        public static int OldSelectedIndex = -1;
        public static string SelectedTemplateName = "";
        public static string DefaultTempalteDir = System.AppContext.BaseDirectory.Substring(0, System.AppContext.BaseDirectory.LastIndexOf(@"\team_development")) + @"\Libary\WordTemplates";

        //填写项 默认值
        public static string ToName = "";
        public static string Reason = "";
        public static DateTime StartTime = DateTime.Now;
        public static DateTime EndTime = DateTime.Now;
        public static string FromName = "";
        public static string StudentNum = "";
        public static string Department = ""; //模板里没有
        public static string Phone = "";

        public static string GetSelectedTemplatePath()
        {
            if (TemplatesFilePath.Count > SelectedIndex && SelectedIndex >= 0)
                return TemplatesFilePath[SelectedIndex];
            else
                return "";
        }

        public static string GetOldSelectedTemplatePath()
        {
            if (TemplatesFilePath.Count > OldSelectedIndex && OldSelectedIndex >= 0)
                return TemplatesFilePath[OldSelectedIndex];
            else
                return "";
        }

        public static string GetSelectedTemplateName()
        {
            if (TemplatesFilePath.Count > SelectedIndex && SelectedIndex >= 0)
                return Path.GetFileNameWithoutExtension(TemplatesFilePath[SelectedIndex]);
            else
                return "";
        }

        public static List<string> GetNowTemplateNames()
        {
            List<string> ret = new List<string>();
            foreach (string filePath in AbsenceWordManager.TemplatesFilePath)
            {
                ret.Add(Path.GetFileNameWithoutExtension(filePath));
            }
            return ret;
        }

        public static List<string> GetWordTemplateList(string templateDir)
        {
            Log.log.Info("Call GetWordTemplateList In TemplateSelect");

            AbsenceWordManager.TemplatesFilePath.Clear(); //清空模板路径列表

            List<string> ret = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(templateDir);
            FileInfo[] fileInfo = dir.GetFiles("*.dot");
            if (fileInfo.Length != 0)
            {
                foreach (FileInfo f in fileInfo)
                {
                    AbsenceWordManager.TemplatesFilePath.Add(f.FullName);   //更新模板路径列表
                    ret.Add(Path.GetFileNameWithoutExtension(f.FullName));  //返回的是不含扩展名的文件名字
                }
            }
            return ret;
        }


        public static void OpenTemplate(string templatePath, RichTextBox richTextBox)
        {
            if (!File.Exists(templatePath))
            {
                MessageBox.Show(string.Format("{0}  模版文件不存在，请先设置模版文件。", templatePath));
                return;
                
            }

            Word.Application app = new Word.Application(); //创建一个Word应用程序实例
            Word.Document doc = null;  //生成的文档

            object missing = System.Reflection.Missing.Value; //初始化默认值
            object file = templatePath;
            object readOnly = false;//不是只读
            object isVisible = false;

            object unknow = Type.Missing;

            try
            {
                doc = app.Documents.Open(ref file, ref missing, ref readOnly,
                 ref missing, ref missing, ref missing, ref missing, ref missing,
                 ref missing, ref missing, ref missing, ref isVisible, ref missing,
                 ref missing, ref missing, ref missing);

                doc.ActiveWindow.Selection.WholeStory();//全选word文档中的数据
                doc.ActiveWindow.Selection.Copy();//复制数据到剪切板
                richTextBox.Paste();//richTextBox粘贴数据
                                    //richTextBox1.Text = doc.Content.Text;//显示无格式数据
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close(ref missing, ref missing, ref missing);
                    doc = null;
                }

                if (app != null)
                {
                    app.Quit(ref missing, ref missing, ref missing);
                    app = null;
                }
            }
        }

        public static void SetBookMark(Word.Document doc, string bookmarkName, string value)
        {
            if (doc == null) return;
            if (doc.Bookmarks.Exists(bookmarkName))
            {
                doc.Bookmarks.get_Item(bookmarkName).Range.Text = value;
            }

        }

        public static void GenerateWord(string templatePath, string toName, string reason, string department,
            string dayLast, string startMonth, string startDay, string endMonth, string endDay,
            string fromName, string studentNum, string phone, string year, string month,
            string day, bool isSave, RichTextBox richTextBox)
        {
            if (!File.Exists(templatePath))
            {
                MessageBox.Show(string.Format("{0}  模版文件不存在，请先设置模版文件。", templatePath));
                return;
            }

            string dir = System.AppDomain.CurrentDomain.BaseDirectory + @"\";// templatePath.Substring(0, templatePath.LastIndexOf(@"\") + 1);
            string temporatyFile = dir + "temp.docx";
            File.Copy(templatePath, temporatyFile, true);

            Word.Application app = new Word.Application(); //创建一个Word应用程序实例
            Word.Document doc = null;  //生成的文档

            object missing = System.Reflection.Missing.Value; //初始化默认值
            object file = temporatyFile;
            object readOnly = false;//不是只读
            object isVisible = false;

            object unknow = Type.Missing;

            try
            {
                doc = app.Documents.Open(ref file, ref missing, ref readOnly,
                 ref missing, ref missing, ref missing, ref missing, ref missing,
                 ref missing, ref missing, ref missing, ref isVisible, ref missing,
                 ref missing, ref missing, ref missing);

                //填写

                SetBookMark(doc, "ToName", toName);
                SetBookMark(doc, "Reason", reason);
                SetBookMark(doc, "DayLast", dayLast);
                SetBookMark(doc, "Department", department);
                SetBookMark(doc, "StartMonth", startMonth);
                SetBookMark(doc, "StartDay", startDay);
                SetBookMark(doc, "EndMonth", endMonth);
                SetBookMark(doc, "EndDay", endDay);
                SetBookMark(doc, "FromName", fromName);
                SetBookMark(doc, "StudentNum", studentNum);
                SetBookMark(doc, "Phone", phone);
                SetBookMark(doc, "Year", year);
                SetBookMark(doc, "Month", month);
                SetBookMark(doc, "Day", day);

                if (isSave)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Word Document(*.docx)|*.docx";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string wordName = sfd.FileName;

                        doc.SaveAs(wordName, ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing, ref missing, ref missing,
                            ref missing);
                        MessageBox.Show("保存成功");
                    }
                }
                else
                {
                    doc.ActiveWindow.Selection.WholeStory();//全选word文档中的数据
                    doc.ActiveWindow.Selection.Copy();//复制数据到剪切板
                    richTextBox.Paste();//richTextBox粘贴数据
                                        //richTextBox1.Text = doc.Content.Text;//显示无格式数据
                }
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close(ref missing, ref missing, ref missing);
                    doc = null;
                }

                if (app != null)
                {
                    app.Quit(ref missing, ref missing, ref missing);
                    app = null;
                }
            }

        }

        public static void DeleteTemporaryFile()
        {
            string dir = System.AppDomain.CurrentDomain.BaseDirectory + @"\";// templatePath.Substring(0, templatePath.LastIndexOf(@"\") + 1);
            string temporatyFile = dir + "temp.docx";
            if (File.Exists(temporatyFile))
            {
                File.Delete(temporatyFile);
            }
        }
    }


}
