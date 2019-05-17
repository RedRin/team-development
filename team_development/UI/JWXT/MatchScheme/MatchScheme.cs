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
using Lib.GetJWXT;

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
            MatchSchemeItem matchSchemeItem = GetJWXT.jwxt.GetMatchSchemeItem(Lib.GetJWXT.GetJWXT.jwxt.GetMatchScheme().Body.InnerHtml);

            for (int i = 0; i < matchSchemeItem.needs.Count; i++)
            {
                AddText(matchSchemeItem.needs[i], 3, i+1);
            }

            for (int i = 0; i < matchSchemeItem.study.Count; i++)
            {
                AddText(matchSchemeItem.study[i], 4, i+1);
            }

            for (int i = 0; i < matchSchemeItem.lefts.Count; i++)
            {
                AddText(matchSchemeItem.lefts[i], 5, i + 1);
            }

        }

        private void AddText(string str,int column, int row)
        {
            Label lb = new Label();
            lb.Text = str;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            this.tableLayoutPanel1.Controls.Add(lb, column, row);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Log.log.Info("Click Refresh button In MatchScheme Form.");
        }
    }
}
