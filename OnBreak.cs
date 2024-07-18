using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyBreakTime
{
    public partial class OnBreak : Form
    {
        public OnBreak()
        {
            InitializeComponent();
        }

        private void tmrBreakTime_Tick(object sender, EventArgs e)
        {
            tmrBreakTime.Stop();
            BreakOver newBreakOver = new BreakOver();
            newBreakOver.Show();
            Close();
        }

        private void OnBreak_Load(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
