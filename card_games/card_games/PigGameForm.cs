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
    public partial class PigGameForm : Form {
        Pig_Single_Die_Game pigGame = new Pig_Single_Die_Game();
        private string player;
        private bool failed;
        private bool won;
        public PigGameForm() {
            InitializeComponent();
            pigGame.SetUpGame();
            DrawDie();
            player = pigGame.GetFirstPlayerName();
            whoseTurnLabel.Text = player;
            p1TotalBox.Text = pigGame.GetPointsTotal("Player 1").ToString();
            p2TotalBox.Text = pigGame.GetPointsTotal("Player 2").ToString();
        }

        private void DrawDie() {
            diePicture.Image = Images.GetDieImage(pigGame.GetFaceValue());
        }

        private void rollButton_Click(object sender, EventArgs e) {
            failed = pigGame.PlayGame();
            won = pigGame.HasWon();
            DrawDie();
            p1TotalBox.Text = pigGame.GetPointsTotal("Player 1").ToString();
            p2TotalBox.Text = pigGame.GetPointsTotal("Player 2").ToString();
            rollHoldLabel.Text = "Roll or Hold";
            holdButton.Enabled = true;
            if (failed == true) {
                MessageBox.Show(string.Format("Sorry you have thrown a 1. \n Your turn is over! " +
                    "\n Your score reverts to {0}", pigGame.GetPointsTotal(player).ToString()));
                holdButton.PerformClick();
            }
            if (won == true) {
                MessageBox.Show(string.Format("{0} has won!\n\n Well Done.", player));
                anotherGroup.Enabled = true;
                rollButton.Enabled = false;
                holdButton.Enabled = false;
            }
        }

        private void holdButton_Click(object sender, EventArgs e) {
            player = pigGame.GetNextPlayerName();
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
            pigGame.SetUpGame();
            DrawDie();
            player = pigGame.GetFirstPlayerName();
            whoseTurnLabel.Text = player;
            p1TotalBox.Text = pigGame.GetPointsTotal("Player 1").ToString();
            p2TotalBox.Text = pigGame.GetPointsTotal("Player 2").ToString();
            rollHoldLabel.Text = "Roll Die";
            anotherGroup.Enabled = false;
            yesRadio.Checked = false;
            rollButton.Enabled = true;
        }

        private void diePicture_Click(object sender, EventArgs e) {

        }

        private void whoseTurnLabel_Click(object sender, EventArgs e) {

        }

        private void p2TotalBox_TextChanged(object sender, EventArgs e) {

        }
    }


}
