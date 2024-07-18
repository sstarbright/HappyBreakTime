using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HappyBreakTime
{
    public partial class LockWarning : Form
    {
        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();

        public LockWarning()
        {
            InitializeComponent();
        }

        int minutesLeft = 5;

        int secondsLeft = 0;

        private void StartBreak()
        {
            tmrStartBreak.Stop();
            Program.notes = txtNotes.Text;
            OnBreak newBreak = new OnBreak();
            LockWorkStation();
            newBreak.Show();
            Close();
        }

        private void tmrStartBreak_Tick(object sender, EventArgs e)
        {
            if (secondsLeft < 1)
            {
                if (minutesLeft > 0)
                {
                    minutesLeft--;
                    secondsLeft = 59;
                    lblLockDisplay.Text = $"Locking in {minutesLeft}:{secondsLeft.ToString("D2")}";
                } else
                {
                    StartBreak();
                }
            } else
            {
                secondsLeft--;
                lblLockDisplay.Text = $"Locking in {minutesLeft}:{secondsLeft.ToString("D2")}";
            }
        }

        private void btnStartBreak_Click(object sender, EventArgs e)
        {
            StartBreak();
        }

        private void LockWarning_Load(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
