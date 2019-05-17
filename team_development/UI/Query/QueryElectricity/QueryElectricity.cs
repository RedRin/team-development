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
        private Waiting wait = new Waiting();
        private GetElectricCharge gec = new GetElectricCharge();
        private Mutex charge_mtx = new Mutex();
        public QueryElectricity()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            gec.GetElectric(Dorm.Text,new SetCharge(this.SetElectricCharge));
            wait.StartKiller(3000, IsOK);
        }

        private void TurnToForm(Form f)
        {
            ((Form1)(this.ParentForm)).TurnForm(f);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            gec.GetElectric(Dorm.Text, new SetCharge(this.SetElectricCharge));
            wait.StartKiller(1000,IsOK);
        }


        private void QueryElectricity_Load(object sender, EventArgs e)
        {

        }

        public void SetElectricCharge(string charge) {
            charge_mtx.WaitOne();
            result.Text = charge;
            charge_mtx.ReleaseMutex();
        }

        public bool IsOK() {
            bool ok = false;
            charge_mtx.WaitOne();
            if (result.Text.Length > 0)
                ok = true;
            charge_mtx.ReleaseMutex();
            return ok;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}