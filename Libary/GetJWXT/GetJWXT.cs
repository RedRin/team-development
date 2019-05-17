using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Lib;
using mshtml;

namespace Lib.GetJWXT
{
    public class GetJWXT
    {

        public static GetJWXT jwxt = new GetJWXT();
        private WebBrowser web = new WebBrowser();
        private System.Threading.AutoResetEvent obj = new System.Threading.AutoResetEvent(false);
        private bool isNavigate = false;
        private bool isGetInto = false;
        private System.Threading.AutoResetEvent statusObj = new System.Threading.AutoResetEvent(false);

        public bool GetStatus()
        {
            bool result = false;
            statusObj.WaitOne();
            result = isGetInto;
            statusObj.Set();
            return result;
        }
        public void SetStatus(bool status)
        {
            statusObj.WaitOne();
            isGetInto = status;
            statusObj.Set();
        }

        public GetJWXT()
        {
            web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebDocumentCompleted);
            web.ScriptErrorsSuppressed = true;
            web.Navigated += new WebBrowserNavigatedEventHandler(NavigatedEventHandler);
            statusObj.Set();
        }

        private void NavigatedEventHandler(object sender, WebBrowserNavigatedEventArgs e)
        {
            IHTMLWindow2 win = (IHTMLWindow2)web.Document.Window.DomWindow;
            string s = "window.alert = null;";
            win.execScript(s, "javascript");
            if (e.Url.AbsolutePath == "/areaTopLogo.aspx")
                SetStatus(true);
            else
                Log.log.Error("Get a null object from e.Url.AbsolutePath");
        }

        public Bitmap GetValidateImage()
        {
            //if (!isNavigate)
            // {
            web.Navigate("https://jwxt.jnu.edu.cn/");
            Wait();
            isNavigate = true;
            //}

            Bitmap clip = null;
            try
            {
                HtmlElement validateImg = web.Document.Images[1];
                validateImg.Style = "position: absolute; z-index: 9999; top: 0px; left: 0px";
                clip = new Bitmap(validateImg.ClientRectangle.Width, validateImg.ClientRectangle.Height);
                web.DrawToBitmap(clip, new Rectangle(new Point(), validateImg.ClientRectangle.Size));
                //validateImageEventHandler(clip);
               
            }
            catch (Exception e)
            {
                MessageBox.Show("登陆失败");
            }
            return clip;
        }

        public bool Login(string username, string pwd,string validate)
        {
            //string validate = OCR.GetValidateCode(GetValidateImage());            
            web.Document.GetElementById("txtYHBS").SetAttribute("value", username);
            web.Document.GetElementById("txtYHMM").SetAttribute("value", pwd);
            web.Document.GetElementById("txtFJM").SetAttribute("value", validate);
            web.Document.GetElementById("btnLogin").InvokeMember("click");
            
            Wait();
            web.Navigate("https://jwxt.jnu.edu.cn/IndexPage.aspx");
            string str = "\r\n<!DOCTYPE html PUBLIC \"-//W3C//Dtd html 4.0 transitional//EN\">\r\n<html>\r\n\t<head>\r\n\t\t<title>����ܹ�</title>\r\n\t\t<meta content=\"Microsoft Visual Studio .NET 7.1\" name=\"GENERATOR\"/>\r\n\t\t<meta content=\"Visual Basic .NET 7.1\" name=\"CODE_LANGUAGE\"/>\r\n\t\t<meta content=\"JavaScript\" name=\"vs_defaultClientScript\"/>\r\n\t\t<meta content=\"http://schemas.microsoft.com/intellisense/ie5\" name=\"vs_targetSchema\"/>\r\n\t\t<script  type=\"text/javascript\" language=\"javascript\">\r\n\t\t\tfunction doHideLeftWindow()\r\n\t\t\t{\r\n\t\t\t    window.mainFrameSet.rows=\"0,*,0\";\r\n\t\t\t\twindow.contentFrameSet.cols=\"0,15,*\";\r\n\t\t\t}\r\n\t\t\tfunction doShowLeftWindow()\r\n\t\t\t{\r\n\t\t\t   window.mainFrameSet.rows=\"58,*,26\";\r\n\t\t\t   window.contentFrameSet.cols=\"220,15,*\";\r\n\t\t\t}\t\t\r\n\t\t</script>\r\n\t</head>\r\n\t\t<frameset id=\"mainFrameSet\" rows=\"58,*,26\" >\r\n\t\t\t<frame id=\"topFrameLogo\"  src=\"areaTopLogo.aspx\"  frameborder=\"0\"\r\n\t\t\t\tscrolling=\"no\"/>\r\n\t\t\t<frameset id=\"contentFrameSet\" style=\"\" cols=\"220,15,*\" >\r\n\t\t\t\t<frame id=\"leftFrame\"  src=\"areaLeft.aspx\" frameborder=\"0\" scrolling=\"no\"/>\t\t\t\t\r\n\t\t\t    <frame id=\"middleFrame\"  src=\"areaMiddle.aspx\" frameborder=\"0\" scrolling=\"no\"/>\r\n\t\t\t\t<frame id=\"mainFrame\" src=\"areaMain.aspx\" frameborder=\"0\"scrolling=\"no\"/>\t\t\t\t\t\r\n\t\t\t</frameset>\r\n\t\t\t<frame id=\"footFrame\"  src=\"areaFoot.aspx\" frameborder=\"0\" scrolling=\"no\"/>\r\n\t    </frameset>\r\n</html>\r\n";
            if (web.DocumentText == str)
            {
                return true;
            }
            else return false;
        }

        public HtmlDocument GetCourseList()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_XK_MainCX.aspx");
            Wait();
            return web.Document;
        }

        public HtmlDocument SelectCourse()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_Pk_RlRscx.aspx");
            Wait();
            web.Document.GetElementById("dlstKclb").SetAttribute("value", "122");
            web.Document.GetElementById("dlstXqu").SetAttribute("value", "珠海校区");
            web.Document.GetElementById("lbtnSearch").InvokeMember("click");
            Wait();

            return web.Document;
        }

        public HtmlDocument GetGPA()
        {
            try
            {
                web.Navigate("https://jwxt.jnu.edu.cn/Secure/Cjgl/Cjgl_Cjcx_WdCj.aspx");
                Wait();
                web.Document.GetElementById("lbtnQuery").InvokeMember("click");
                Wait();
            }
            catch (Exception)
            {
                MessageBox.Show("获取失败，请检查教务处用户名和密码");
            }
            return web.Document;
        }

        public HtmlDocument GetMatchScheme()
        {
            web.Navigate("https://jwxt.jnu.edu.cn/default.aspx");
            Wait();
            return web.Document;
        }

        private void WebDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            obj.Set();
            web.ScriptErrorsSuppressed = true;
        }

        private void Wait()
        {
            obj.Reset();
            while (obj.WaitOne(10, false) == false)
            {
                Application.DoEvents();
            }
            
        }

        public MatchSchemeItem GetMatchSchemeItem(string str)
        {

            List<string> needs = new List<string>();
            List<string> study = new List<string>();
            List<string> lefts = new List<string>();

            Regex reg = new Regex(@"<TD class=needs>[\d|.]*</TD>", RegexOptions.IgnoreCase);
            MatchCollection mc = reg.Matches(str);
            foreach (Match m in mc)
            {
                string item = m.Value;
                int IndexofA = item.IndexOf(">");
                int IndexofB = item.IndexOf("</TD>");
                string Ru = item.Substring(IndexofA + 1, IndexofB - IndexofA - 1);
                needs.Add(Ru);
            }

            reg = new Regex(@"<TD class=study>[\d|.]*</TD>", RegexOptions.IgnoreCase);
            mc = reg.Matches(str);
            foreach (Match m in mc)
            {
                string item = m.Value;
                int IndexofA = item.IndexOf(">");
                int IndexofB = item.IndexOf("</TD>");
                string Ru = item.Substring(IndexofA + 1, IndexofB - IndexofA - 1);
                study.Add(Ru);
            }

            reg = new Regex(@"<TD class=lefts>[\d|.]*</TD>", RegexOptions.IgnoreCase);
            mc = reg.Matches(str);
            foreach (Match m in mc)
            {
                string item = m.Value;
                int IndexofA = item.IndexOf(">");
                int IndexofB = item.IndexOf("</TD>");
                string Ru = item.Substring(IndexofA + 1, IndexofB - IndexofA - 1);
                lefts.Add(Ru);
            }

            MatchSchemeItem matchSchemeItem = new MatchSchemeItem(needs, study, lefts);
            return matchSchemeItem;
            
        }

        public List<Gpa> GetGpaList(string str)
        {
            List<Gpa> Gpas = new List<Gpa>();
            Regex reg = new Regex(@"<TD>[^<]*</TD>", RegexOptions.IgnoreCase);
            MatchCollection mc = reg.Matches(str);
            string item;
            int i = 0;
            string a = "";
            string schoolyear = "";
            string semester = "";
            string coursename = "";
            float credit = 0, mark = 0, gp = 0;
            string coursecategory = "";
            foreach (Match m in mc)
            {
                item = m.Value;
                Console.WriteLine(item);//
                int IndexofA = item.IndexOf(">");
                int IndexofB = item.IndexOf("</TD>");
                string Ru = item.Substring(IndexofA + 1, IndexofB - IndexofA - 1);
                if (!Ru.Equals(""))
                {
                    switch (i)
                    {
                        case 0:
                            schoolyear = Ru;
                            break;
                        case 1:
                            semester = Ru;
                            break;
                        case 2:
                            coursename = Ru;
                            break;
                        case 3:
                            credit = Convert.ToSingle(Ru);
                            break;
                        case 4:
                            mark = Convert.ToSingle(Ru);
                            break;
                        case 5:
                            gp = Convert.ToSingle(Ru);
                            break;
                        case 9:
                            coursecategory = Ru;

                            Gpa gpa = new Gpa(schoolyear, semester, coursename, credit, mark, gp, coursecategory);
                            Gpas.Add(gpa);
                            break;
                    }
                    i++;
                    i = i % 11;

                }
            }
            return Gpas;
        }

    }



    
}
