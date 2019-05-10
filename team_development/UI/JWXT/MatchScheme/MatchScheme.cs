using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib;
using System.Windows.Forms;

namespace team_development.UI.MatchScheme
{
    public partial class MatchScheme : Form
    {
        public MatchScheme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Log.log.Info("CALL tableLayoutPane11_Paint function.");
            tableLayoutPanel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel1, true, null);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MatchScheme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Log.log.Info("Click Refresh button In MatchScheme Form.");
        }
    }
}
