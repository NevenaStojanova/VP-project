using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            cbChoices.SelectedIndex = 1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MG4x4 mg4x4 = new MG4x4();
            if(cbChoices.Text == "4 X 4")
            {
                this.Hide();
                mg4x4.Show();
            }
            
        }

        private void startForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
