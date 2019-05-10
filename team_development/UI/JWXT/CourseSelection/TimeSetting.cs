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
namespace team_development.UI.CourseSelection
{
    public partial class TimeSetting : Form
    {
        public TimeSetting()
        {
            Log.log.Info("LOADING form TimeSetting.");
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click OKButton in TimeSetting Form.");
            Form lt = new LeftTime();//show left time
            lt.Show();
            this.Close();
        }

        private void TimeSetting_Load(object sender, EventArgs e)
        {
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click CancelButton in TimeSetting Form.");
            this.Close();
        }
    }
}
