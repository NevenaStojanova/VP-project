using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class MG6x6 : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;

        Random random = new Random();

        List<string> icons;

        private int timeLeft = 55;
        //private int firstClickWaitTime = 1;

        private SoundPlayer match = new SoundPlayer("Ding-sound-shiny.wav");
        private SoundPlayer mismatch = new SoundPlayer("Computer Error Alert.wav");

        private bool mute = false;

        private void AssignIconsToSquares()
        {
            icons = new List<string>()
            {
                "A", "A", "B", "B", "C", "C", "D", "D", "E", "E", "F", "F", "G", "G", "H", "H", "I", "I",
                "J", "J", "K", "K", "M", "M", "P", "P", "Q", "Q", "R", "R", "S", "S", "T", "T", "e", "e"
            };


            foreach (Control control in tlp6x6.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public MG6x6()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void MG6x6_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartForm startF = new StartForm();
            startF.Show();
        }

        private void label_Click(object sender, EventArgs e)
        {

            if (tNotMatching.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;


                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                if (firstClicked.Text == secondClicked.Text && mute == false)
                {
                    match.Play();

                }

                CheckForWinner();


                if (firstClicked.Text == secondClicked.Text)
                {
                    //if (mute == false) match.Play();
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }


                if (mute == false) mismatch.Play();
                tNotMatching.Start();
            }
        }

        private void tNotMatching_Tick(object sender, EventArgs e)
        {
            tNotMatching.Stop();


            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;


            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {

            foreach (Control control in tlp6x6.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }


            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
        }

        private void tCountdown_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                if (timeLeft < 10) lTimeLeft.Text = "00:0" + timeLeft;
                else lTimeLeft.Text = "00:" + timeLeft;
            }
            else
            {

                tCountdown.Stop();
                lTimeLeft.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                Close();
            }
        }

        private void MG6x6_Load(object sender, EventArgs e)
        {
            tCountdown.Start();
        }

        private void startNewGame()
        {
            foreach (Control control in tlp6x6.Controls)
            {
                Label iconLabel = control as Label;

                iconLabel.ForeColor = iconLabel.BackColor;
            }
            AssignIconsToSquares();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            tCountdown.Stop();
            timeLeft = 55;
            tCountdown.Start();
            startNewGame();
        }

        private void btnStartForm_Click(object sender, EventArgs e)
        {
            tCountdown.Stop();
            this.Close();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (mute == false)
            {
                mute = true;
                btnMute.BackgroundImage = Properties.Resources.UnMute_Icon;
            }
            else if (mute == true)
            {
                mute = false;
                btnMute.BackgroundImage = Properties.Resources.Mute_Icon;
            }
        }

        private void btnNewGame_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnNewGame_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

      
    }
}
