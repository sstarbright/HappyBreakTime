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
    public partial class BreakOver : Form
    {
        public BreakOver()
        {
            InitializeComponent();
        }

        private void btnStartWorking_Click(object sender, EventArgs e)
        {
            if (Program.notes.Length > 0 )
            {
                BreakNotes newBreakNotes = new BreakNotes();
                newBreakNotes.Show();
            }
            Program.workTimer.Start();
            Close();
        }

        private void BreakOver_Load(object sender, EventArgs e)
        {
            Focus();
        }

        private void BreakOver_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnStopWorking_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
