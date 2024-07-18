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
    public partial class BreakNotes : Form
    {
        public BreakNotes()
        {
            InitializeComponent();
        }

        private void BreakNotes_Load(object sender, EventArgs e)
        {
            txtNotes.Text = Program.notes;
            Focus();
        }
    }
}
