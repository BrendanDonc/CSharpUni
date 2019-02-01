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
using Low_Level_Objects_Library;


namespace card_games {
    public partial class z : Form {



        Twenty_One_Game twenty_Game = new Twenty_One_Game();
        Hand player;
        Hand dealer;
        private bool failed = false;
        private int aceCounter = 0;
        private int dealerWon = 0;
        private int playerWon = 0;
        public z() {
            InitializeComponent();
            twenty_Game.SetUpGame();
            btnHit.Enabled = false;
            btnStand.Enabled = false;

            Hand player = twenty_Game.GetHand(1);


        }
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void btnDeal(object sender, EventArgs e) {



        }

        private void btnDealPlz_Click(object sender, EventArgs e) {
            p2TotalBox.Text = twenty_Game.GetTotalPoints(0).ToString();
            p1TotalBox.Text = twenty_Game.GetTotalPoints(1).ToString();
            player = twenty_Game.GetHand(0);
            dealer = twenty_Game.GetHand(1);
            DisplayGuiHand(player, playerTableLayoutPanel);
            DisplayGuiHand(dealer, dealerTableLayoutPanel);


            btnDealPlz.Enabled = false;
            btnHit.Enabled = true;
            btnStand.Enabled = true;
        }

        private void btnHit_Click(object sender, EventArgs e) {
            twenty_Game.DealOneCardTo(0);
            player = twenty_Game.GetHand(0);
            if (twenty_Game.IsItAce(0) == true) {
                DialogResult Exit = MessageBox.Show("Do You want Ace to Equal One?", "Exit", MessageBoxButtons.YesNo);
                if (Exit == DialogResult.Yes) {
                    aceCounter++;
                } else if (Exit == DialogResult.No) {
                    aceCounter++;
                }
            }
            DisplayGuiHand(player, playerTableLayoutPanel);
            p2TotalBox.Text = twenty_Game.GetTotalPoints(0).ToString();

            if (twenty_Game.GetTotalPoints(0) > 21) {
                btnHit.Enabled = false;
                lblBustedPlayer.Visible = true;
                btnStand.Enabled = false;
            }
            if (twenty_Game.GetTotalPoints(0) == twenty_Game.GetTotalPoints(1)) {
                MessageBox.Show(string.Format("You Have Drawn with the dealer! GOOD GAME!"));
                dealerWon += 1;
                playerWon += 1;
                DialogResult Exit = MessageBox.Show("Restart?", "Exit", MessageBoxButtons.YesNo);
                if (Exit == DialogResult.Yes) {
                    twenty_Game.ResetTotals();
                    textGamesWonDealer.Text = dealerWon.ToString();
                    textGamesWonPlayer.Text = playerWon.ToString();
                    twenty_Game.SetUpGame();
                    btnDealPlz.Enabled = true;
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                    lblBustedDealer.Visible = false;
                    lblBustedPlayer.Visible = false;
                } else if (Exit == DialogResult.No) {
                    this.Close();
                }
            } else if (twenty_Game.GetTotalPoints(0) > twenty_Game.GetTotalPoints(1) && twenty_Game.GetTotalPoints(0) < 22) {
                MessageBox.Show(string.Format("You Have beaten the dealer!"));
                playerWon += 1;
                DialogResult Exit = MessageBox.Show("Restart?", "Exit", MessageBoxButtons.YesNo);
                if (Exit == DialogResult.Yes) {
                    twenty_Game.ResetTotals();
                    textGamesWonPlayer.Text = playerWon.ToString();
                    twenty_Game.SetUpGame();
                    btnDealPlz.Enabled = true;
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                    lblBustedDealer.Visible = false;
                    lblBustedPlayer.Visible = false;
                } else if (Exit == DialogResult.No) {
                    this.Close();
                }
            } else if (twenty_Game.GetTotalPoints(0) < twenty_Game.GetTotalPoints(1) && twenty_Game.GetTotalPoints(1) < 22) {
                MessageBox.Show(string.Format("Dealer has beaten you"));
                dealerWon += 1;
                DialogResult Exit = MessageBox.Show("Restart?", "Exit", MessageBoxButtons.YesNo);
                if (Exit == DialogResult.Yes) {
                    twenty_Game.ResetTotals();
                    textGamesWonDealer.Text = dealerWon.ToString();
                    twenty_Game.SetUpGame();
                    btnDealPlz.Enabled = true;
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                    lblBustedDealer.Visible = false;
                    lblBustedPlayer.Visible = false;
                } else if (lblBustedDealer.Visible == true) {
                    MessageBox.Show(string.Format("You Have beaten the dealer!"));
                    playerWon += 1;
                    DialogResult leave = MessageBox.Show("Restart?", "Exit", MessageBoxButtons.YesNo);
                    if (leave == DialogResult.Yes) {
                        twenty_Game.ResetTotals();
                        textGamesWonPlayer.Text = playerWon.ToString();
                        twenty_Game.SetUpGame();
                        btnDealPlz.Enabled = true;
                        btnHit.Enabled = false;
                        btnStand.Enabled = false;
                        lblBustedDealer.Visible = false;
                        lblBustedPlayer.Visible = false;
                    }
                } else if (lblBustedPlayer.Visible == true) {

                    MessageBox.Show(string.Format("Dealer has beaten you"));
                    dealerWon += 1;
                    DialogResult leave = MessageBox.Show("Restart?", "Exit", MessageBoxButtons.YesNo);
                    if (leave == DialogResult.Yes) {
                        twenty_Game.ResetTotals();
                        textGamesWonDealer.Text = dealerWon.ToString();
                        twenty_Game.SetUpGame();
                        btnDealPlz.Enabled = true;
                        btnHit.Enabled = false;
                        btnStand.Enabled = false;
                        lblBustedDealer.Visible = false;
                        lblBustedPlayer.Visible = false;
                    } else if (leave == DialogResult.No) {
                        this.Close();
                    }

                }

            }
        }

        private void btnStand_Click(object sender, EventArgs e) {
            btnHit.Enabled = false;

            while (twenty_Game.GetTotalPoints(1) <= 17) {
                twenty_Game.PlayForDealer();
                dealer = twenty_Game.GetHand(1);
                p1TotalBox.Text = twenty_Game.GetTotalPoints(1).ToString();
                DisplayGuiHand(dealer, dealerTableLayoutPanel);
            }

            if (twenty_Game.GetTotalPoints(1) > 21) {
                lblBustedDealer.Visible = Enabled;
            }
            if (twenty_Game.GetTotalPoints(0) == twenty_Game.GetTotalPoints(1)) {
                MessageBox.Show(string.Format("You Have Drawn with the dealer! GOOD GAME!"));
                dealerWon += 1;
                playerWon += 1;
                DialogResult Exit = MessageBox.Show("Restart?", "Exit", MessageBoxButtons.YesNo);
                if (Exit == DialogResult.Yes) {
                    twenty_Game.ResetTotals();
                    textGamesWonDealer.Text = dealerWon.ToString();
                    textGamesWonPlayer.Text = playerWon.ToString();
                    twenty_Game.SetUpGame();
                    btnDealPlz.Enabled = true;
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                    lblBustedDealer.Visible = false;
                    lblBustedPlayer.Visible = false;
                } else if (Exit == DialogResult.No) {
                    this.Close();
                }
            } else if (twenty_Game.GetTotalPoints(0) > twenty_Game.GetTotalPoints(1) && twenty_Game.GetTotalPoints(0) < 22) {
                MessageBox.Show(string.Format("You Have beaten the dealer!"));
                playerWon += 1;
                DialogResult Exit = MessageBox.Show("Restart?", "Exit", MessageBoxButtons.YesNo);
                if (Exit == DialogResult.Yes) {
                    twenty_Game.ResetTotals();
                    textGamesWonPlayer.Text = playerWon.ToString();
                    twenty_Game.SetUpGame();
                    btnDealPlz.Enabled = true;
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                    lblBustedDealer.Visible = false;
                    lblBustedPlayer.Visible = false;
                } else if (Exit == DialogResult.No) {
                    this.Close();
                }
            } else if (twenty_Game.GetTotalPoints(0) < twenty_Game.GetTotalPoints(1) && twenty_Game.GetTotalPoints(1) < 22) {
                MessageBox.Show(string.Format("Dealer has beaten you"));
                dealerWon += 1;
                DialogResult Exit = MessageBox.Show("Restart?", "Exit", MessageBoxButtons.YesNo);
                if (Exit == DialogResult.Yes) {
                    twenty_Game.ResetTotals();
                    textGamesWonDealer.Text = dealerWon.ToString();
                    twenty_Game.SetUpGame();
                    btnDealPlz.Enabled = true;
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                    lblBustedDealer.Visible = false;
                    lblBustedPlayer.Visible = false;
                } else if (lblBustedDealer.Visible == true) {
                    MessageBox.Show(string.Format("You Have beaten the dealer!"));
                    playerWon += 1;
                    DialogResult leave = MessageBox.Show("Restart?", "Exit", MessageBoxButtons.YesNo);
                    if (leave == DialogResult.Yes) {
                        twenty_Game.ResetTotals();
                        textGamesWonPlayer.Text = playerWon.ToString();
                        twenty_Game.SetUpGame();
                        btnDealPlz.Enabled = true;
                        btnHit.Enabled = false;
                        btnStand.Enabled = false;
                        lblBustedDealer.Visible = false;
                        lblBustedPlayer.Visible = false;
                    }
                } else if (lblBustedPlayer.Visible == true) {

                    MessageBox.Show(string.Format("Dealer has beaten you"));
                    dealerWon += 1;
                    DialogResult leave = MessageBox.Show("Restart?", "Exit", MessageBoxButtons.YesNo);
                    if (leave == DialogResult.Yes) {
                        twenty_Game.ResetTotals();
                        textGamesWonDealer.Text = dealerWon.ToString();
                        twenty_Game.SetUpGame();
                        btnDealPlz.Enabled = true;
                        btnHit.Enabled = false;
                        btnStand.Enabled = false;
                        lblBustedDealer.Visible = false;
                        lblBustedPlayer.Visible = false;
                    } else if (Exit == DialogResult.No) {
                        this.Close();
                    }

                }




            }
        }
    }
}
