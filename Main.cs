namespace HappyBreakTime
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Program.workTimer = tmrWorkTime;
        }

        private void tmrWorkTime_Tick(object sender, EventArgs e)
        {
            tmrWorkTime.Stop();
            LockWarning newWarning = new LockWarning();
            newWarning.Show();
        }
    }
}