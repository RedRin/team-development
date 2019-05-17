using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Collections.Specialized;
using Lib;
using System.Windows.Forms;
using System.Threading;

namespace Lib
{
    public class NoticeSearch
    {
        private WebBrowser webBrowser = new WebBrowser();
        
        public NoticeSearch()
        {
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WebBrowserDocumentCompleted);
        }

        public void getHtml(string content)
        {
            Log.log.Info("Get the url of Jinan University.");
            webBrowser.Navigate("https://news.jnu.edu.cn/search/s.aspx?c=&f=0&wd="+content+"&o=1");
        }

        public string getText()
        {
            Log.log.Info("Get the documentText of the url.");
            StreamReader sr = new StreamReader(webBrowser.DocumentStream, Encoding.GetEncoding("UTF-8"));
            string html = sr.ReadToEnd();
            sr.Close();
            int start = html.IndexOf("<ul class=\"searchList\">");
            int end = html.IndexOf("</ul>", start);
            string tbhtm = html.Substring(start, end - start);
            return tbhtm;
        }

        public void WebBrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;
        }
    }
}
