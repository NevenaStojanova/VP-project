using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace MatchingGame
{
    public partial class MG4x4 : Form
    {
        // firstClicked points to the first Label control 
        // that the player clicks, but it will be null 
        // if the player hasn't clicked a label yet
        Label firstClicked = null;

        // secondClicked points to the second Label control 
        // that the player clicks
        Label secondClicked = null;
        // Use this Random object to choose random icons for the squares
        Random random = new Random();

        // Each of these letters is an interesting icon
        // in the Webdings font,
        // and each icon appears twice in this list
        List<string> icons;
        List<string> icons2 = new List<string>()
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "P", "Q", "R", "S",
            "T", "&", "e", "b", "m"
            };

        private int timeLeft = 40;
        //private int firstClickWaitTime = 1;

        //private SoundPlayer match = new SoundPlayer("Ding-sound-shiny.wav");
        //private SoundPlayer mismatch = new SoundPlayer("Computer Error Alert.wav");

        SoundPlayer match = new SoundPlayer(MatchingGame.Properties.Resources.Ding_sound_shiny);
        SoundPlayer mismatch = new SoundPlayer(MatchingGame.Properties.Resources.Computer_Error_Alert);

        private bool mute = false;
               

        /// <summary>
        /// Assign each icon from the list of icons to a random square
        /// </summary>
        private void AssignIconsToSquares()
        {
            icons = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                int r = random.Next(0, icons2.Count);
                icons.Add(icons2[r]);
                icons.Add(icons2[r]);
                icons2.RemoveAt(r);
            }

            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tlp4x4.Controls)
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


        public MG4x4()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void MG4x4_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartForm startF = new StartForm();
            startF.Show();
        }

        private void label_Click(object sender, EventArgs e)
        {
            // The timer is only on after two non-matching 
            // icons have been shown to the player, 
            // so ignore any clicks if the timer is running
            if (tNotMatching.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                // If firstClicked is null, this is the first icon
                // in the pair that the player clicked, 
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                // If the player gets this far, the timer isn't
                // running and firstClicked isn't null,
                // so this must be the second icon the player clicked
                // Set its color to black
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                if (firstClicked.Text == secondClicked.Text && mute == false) match.Play();



                CheckForWinner();

                // If the player clicked two matching icons, keep them 
                // black and reset firstClicked and secondClicked 
                // so the player can click another icon
                if (firstClicked.Text == secondClicked.Text)
                {
                    //if(mute == false) match.Play();
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                // If the player gets this far, the player 
                // clicked two different icons, so start the 
                // timer (which will wait three quarters of 
                // a second, and then hide the icons)
                if(mute == false) mismatch.Play();
                tNotMatching.Start();
            }
        }

        private void tNotMatching_Tick(object sender, EventArgs e)
        {
            tNotMatching.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tlp4x4.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            // If the loop didn’t return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            tCountdown.Stop();
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
                if(timeLeft <10) lTimeLeft.Text = "00:0" + timeLeft;
                else lTimeLeft.Text = "00:" + timeLeft;
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                tCountdown.Stop();
                lTimeLeft.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                Close();
               }
        }

        private void MG4x4_Load(object sender, EventArgs e)
        {
            tCountdown.Start();
        }

        private void startNewGame()
        {
            foreach (Control control in tlp4x4.Controls)
            {
                Label iconLabel = control as Label;

                iconLabel.ForeColor = iconLabel.BackColor;
            }
            AssignIconsToSquares();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            tCountdown.Stop();
            timeLeft = 40;
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
            if(mute == false)
            {
                mute = true;
                btnMute.BackgroundImage = Properties.Resources.UnMute_Icon;
            }
            else if(mute == true)
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

        private void lTimeLeft_Click(object sender, EventArgs e)
        {

        }
    }
}
