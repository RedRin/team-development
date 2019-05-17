using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib
{
    public delegate bool IsOK();
    public class Waiting
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public const int WM_CLOSE = 0x10;
        public Waiting() { }
        private IsOK ok = null;
        public void StartKiller(int span = 5000, IsOK ok = null)
        {
            this.ok = ok;
            Timer timer = new Timer();
            timer.Interval = span; //3秒启动 
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            MessageBox.Show("请稍等", "正在获取");
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            if (null == ok || ok())
            {
                KillMessageBox();
                //停止Timer 
                ((Timer)sender).Stop();
            }
        }

        public void KillMessageBox()
        {
            //按照MessageBox的标题，找到MessageBox的窗口 
            IntPtr ptr = FindWindow(null, "正在获取");
            if (ptr != IntPtr.Zero)
            {
                //找到则关闭MessageBox窗口 
                PostMessage(ptr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            }
        }
    }
}
