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
            
            if(cbChoices.Text == "4 X 4")
            {
                MG4x4 mg4x4 = new MG4x4();
                this.Hide();
                mg4x4.Show();
            }
            else if (cbChoices.Text == "2 X 2")
            {
                MG2x2 mg2x2 = new MG2x2();
                this.Hide();
                mg2x2.Show();
            }
            else
            {
                MG6x6 mg6x6 = new MG6x6();
                this.Hide();
                mg6x6.Show();
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
