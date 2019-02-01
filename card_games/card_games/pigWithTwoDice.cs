using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;

namespace card_games {
    public partial class pigWithTwoDice : Form {
        Pig_Double_Dice pigTwo = new Pig_Double_Dice();
        private string player;
        private bool failed;
        private bool won;


        public pigWithTwoDice() {
            InitializeComponent();
            pigTwo.SetUpGame();
            DrawDie();
            player = pigTwo.GetFirstPlayersName();
            whoseTurnLabel.Text = player;
            p1TotalBox.Text = pigTwo.GetPointsTotal("Player 1").ToString();
            p2TotalBox.Text = pigTwo.GetPointsTotal("Player 2").ToString();

        }

        private void DrawDie() {
            diePicture1.Image = Images.GetDieImage(pigTwo.GetFaceValue(0));
            diePicture2.Image = Images.GetDieImage(pigTwo.GetFaceValue(1));

        }

        private void rollButton_Click(object sender, EventArgs e) {
            failed = pigTwo.PlayGame();
            won = pigTwo.HasWon();
            p1TotalBox.Text = pigTwo.GetPointsTotal("Player 1").ToString();
            p2TotalBox.Text = pigTwo.GetPointsTotal("Player 2").ToString();
            DrawDie();
            if (failed == true) {
                MessageBox.Show(string.Format("Sorry you have thrown a 1. \n Your turn is over! " +
                    "\n Your score reverts to {0}", pigTwo.GetPointsTotal(player).ToString()));
                holdButton.PerformClick();
            }
            if (won == true) {
                MessageBox.Show(string.Format("{0} has won!\n\n Well Done.", player));
                anotherGroup.Enabled = true;
                rollButton.Enabled = false;
                holdButton.Enabled = false;
            }
            holdButton.Enabled = true;
            p1TotalBox.Text = pigTwo.GetPointsTotal("Player 1").ToString();
            p2TotalBox.Text = pigTwo.GetPointsTotal("Player 2").ToString();
            rollHoldLabel.Text = "Roll or Hold";

        }
        private void holdButton_Click(object sender, EventArgs e) {
            player = pigTwo.GetNextPlayersName();
            whoseTurnLabel.Text = player;
            rollHoldLabel.Text = "Roll Die";
            holdButton.Enabled = false;
        }

        private void noRadio_CheckedChanged(object sender, EventArgs e) {
            DialogResult Exit = MessageBox.Show("Do you wish to exit the program?", "Exit", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes) {
                Application.Exit();
            } else if (Exit == DialogResult.No) {
            }
        }

        private void yesRadio_CheckedChanged(object sender, EventArgs e) {
            pigTwo.SetUpGame();
            DrawDie();
            player = pigTwo.GetFirstPlayersName();
            whoseTurnLabel.Text = player;
            p1TotalBox.Text = pigTwo.GetPointsTotal("Player 1").ToString();
            p2TotalBox.Text = pigTwo.GetPointsTotal("Player 2").ToString();
            rollHoldLabel.Text = "Roll Die";
            anotherGroup.Enabled = false;
            yesRadio.Checked = false;
            rollButton.Enabled = true;

        }

        private void p1TotalBox_TextChanged(object sender, EventArgs e) {

        }

        private void holdButton_Click_1(object sender, EventArgs e) {

        }

        private void diePicture1_Click(object sender, EventArgs e) {

        }

        private void noRadio_CheckedChanged_1(object sender, EventArgs e) {
            DialogResult Exit = MessageBox.Show("Do you wish to exit the program?", "Exit", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes) {
                Application.Exit();
            } else if (Exit == DialogResult.No) {
            }
        }
    }
}
