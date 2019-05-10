using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Lib.GetElectricCharge;

namespace team_development.UI.QueryElectricity
{
    public partial class QueryElectricity : Form
    {
        AutoResetEvent obj = new AutoResetEvent(false);
        private GetElectricCharge gec = new GetElectricCharge();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public QueryElectricity()
        {
            InitializeComponent();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(timerTick);
            timer.Stop();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            gec.Login(Dorm.Text);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            try
            {
                int num;
                string elec = gec.GetElectric();
                int.TryParse(elec, out num);
                while (num >= 1000)
                {
                    timer.Stop();
                }
                result.Text = gec.GetElectric();
            }
            catch (Exception E)
            {
                Log.log.Error(E.ToString());
            }
        }

        private void TurnToForm(Form f)
        {
            ((Form1)(this.ParentForm)).TurnForm(f);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = gec.GetElectric();
            }
            catch (Exception E)
            {
                Log.log.Error(E.ToString());
            }
        }


        private void QueryElectricity_Load(object sender, EventArgs e)
        {

        }
    }
}
