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
    public partial class LeftTime : Form
    {
        public LeftTime()
        {
            Log.log.Info("LOADING form LeftTime.");  
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Log.log.Info("Click CancelButton In LeftTime Form.");
            this.Close();
        }

        private void LeftTime_Load(object sender, EventArgs e)
        {

        }
    }
}
