using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO.Compression;
using System.Collections.Specialized;
using Lib;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Lib.GetElectricCharge
{
    public delegate void SetCharge(string charge);
    public class GetElectricCharge
    {
        public void GetElectric(string username, SetCharge sc) {
            GetCharge gc = new GetCharge();
            gc.username = username;
            gc.sc = sc;
            Thread ge = new Thread(gc.Get);
            ge.Start();
        }
        public class GetCharge
        {
            public string username;
            public SetCharge sc;
            public void Get()
            {
                Log.log.Info("Receive the electric data from the electricity charge enquiry website.");
                Process proc = new Process();
                proc.StartInfo.FileName = "../../../Libary/GetElectricCharge/GetElectric.exe";
                proc.StartInfo.Arguments = username;

                proc.StartInfo.UseShellExecute = false;

                proc.StartInfo.RedirectStandardInput = true;

                proc.StartInfo.RedirectStandardOutput = true;

                proc.StartInfo.RedirectStandardError = true;

                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                string elecNum = proc.StandardOutput.ReadToEnd();
                proc.Close();
                sc(elecNum);
            }
        }
    }
}