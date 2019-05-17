using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using Lib.GetElectricCharge;

namespace team_development
{
    static class Program
    {        
        //testwhw
        //testlzp
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //GetElectricCharge.Login("3307");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ValidateForm());
            //Application.Run(new TestForm());
        }
        
    }
}


