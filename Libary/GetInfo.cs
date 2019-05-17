using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib
{
    public class GetInfo {
        private WebBrowser web = new WebBrowser();
        private System.Threading.AutoResetEvent obj = new System.Threading.AutoResetEvent(false);

        public GetInfo()
        {
            web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebDocumentCompleted);
            web.ScriptErrorsSuppressed = true;
        }
        private void WebDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            obj.Set();
            web.ScriptErrorsSuppressed = true;
        }
        public HtmlDocument EnterWeb()
        {
            web.Navigate("https://www.jnu.edu.cn/tz/list.psp");
            Wait();
            return web.Document;
        }
        private void Wait()
        {
            obj.Reset();
            while (obj.WaitOne(10, false) == false)
            {
                Application.DoEvents();
            }
        }

    }
}
