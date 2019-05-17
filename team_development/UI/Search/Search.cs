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
using System.Web;
using System.Threading;

namespace team_development.UI.Search
{
    public partial class Search : Form
    {
        private NoticeSearch notice = new NoticeSearch();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Search()
        {
            InitializeComponent();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timerTick);
            timer.Stop();
            notice.getHtml("%E6%9A%A8%E5%8D%97%E5%A4%A7%E5%AD%A6%E7%8F%A0%E6%B5%B7%E6%A0%A1%E5%8C%BA");
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.DocumentText = notice.getText();               
                timer.Stop();
            }
            catch (Exception E)
            {
                Log.log.Error(E.ToString());
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
        private void TurnToForm(Form f)
        {
            ((Form1)(this.ParentForm)).TurnForm(f);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            foreach (HtmlElement archor in webBrowser1.Document.Links)
            {
                archor.SetAttribute("target", "_self");
            }

            foreach (HtmlElement form in this.webBrowser1.Document.Forms)
            {
                form.SetAttribute("target", "_self");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Log.log.Info("Search the Jinan University's news and notices.");
            string content = Uri.EscapeDataString(searchBox.Text);
            notice.getHtml(content);
            timer.Start();
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Log.log.Info("Go back to the previous page.");
            timer.Start();
            webBrowser1.GoBack();
        }
    }
}
