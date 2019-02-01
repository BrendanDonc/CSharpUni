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
    public partial class solitaireForm : Form {
        Solitaire_Game solitaireGame = new Solitaire_Game();
        private int currentTableau;
        private Card card1 = null;
        private Card card2 = null;
        private int place1 = 0;
        private int place2 = 0;
        private bool multiple1 = false;
        private bool multiple2 = false;
        private int cardIndex1;
        private int cardIndex2;
        public solitaireForm() {
            InitializeComponent();
            solitaireGame.SetUpGame();
            //discard = new Hand(drawPile.DealCards(1));
            for (int i = 0 ; i <= 6 ; i++) {
                DisplayTableaus(i);
            }
            DisplayDiscard();
            DisplayDraw();
            DisplaySuits();

        }
        private void DisplayGuiTableau(Hand hand, TableLayoutPanel tableLayoutPanel, int count, int cards, int handNum) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            for (int i = 0 ; i < count ; i++) {
                Card card = hand.GetCard(i);
                if (i < cards) {
                    // Construct a PictureBox object.
                    PictureBox pictureBox = new PictureBox();
                    // Set the PictureBox to use all of its space
                    pictureBox.Dock = DockStyle.Fill;
                    // Remove spacing around the PictureBox. (Default is 3 pixels.)
                    pictureBox.Margin = new Padding(0);
                    pictureBox.Image = Images.GetBackOfCardImage();
                    pictureBox.Tag = card;
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    // Add the PictureBox object to the tableLayoutPanel.
                    tableLayoutPanel.Controls.Add(pictureBox);
                } else {
                    // Construct a PictureBox object.
                    PictureBox pictureBox = new PictureBox();
                    // Set the PictureBox to use all of its space
                    pictureBox.Dock = DockStyle.Fill;
                    // Remove spacing around the PictureBox. (Default is 3 pixels.)
                    pictureBox.Margin = new Padding(0);
                    pictureBox.Image = Images.GetCardImage(card);
                    // set event-handler for Click on this PictureBox.
                    pictureBox.Click += new EventHandler(pictureBox_Click);
                    // tell the PictureBox which Card object it has the picture of.
                    pictureBox.Tag = card;
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    // Add the PictureBox object to the tableLayoutPanel.
                    tableLayoutPanel.Controls.Add(pictureBox);
                }
            }
            if (count == 0) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = null;
                // set event-handler for Click on this PictureBox.
                pictureBox.Click += new EventHandler(pictureBox_Click);
                // tell the PictureBox which Card object it has the picture of.
                pictureBox.Tag = null;
                pictureBox.Name = handNum.ToString();
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

        private void DisplayTableaus(int tableau) {
            if (tableau == 0) {
                DisplayGuiTableau(solitaireGame.tableauPiles[0], tableauPile0, solitaireGame.tableauPiles[0].GetCount(), solitaireGame.cards[0], 0);
            }
            if (tableau == 1) {
                DisplayGuiTableau(solitaireGame.tableauPiles[1], tableauPile1, solitaireGame.tableauPiles[1].GetCount(), solitaireGame.cards[1], 1);
            }
            if (tableau == 2) {
                DisplayGuiTableau(solitaireGame.tableauPiles[2], tableauPile2, solitaireGame.tableauPiles[2].GetCount(), solitaireGame.cards[2], 2);
            }
            if (tableau == 3) {
                DisplayGuiTableau(solitaireGame.tableauPiles[3], tableauPile3, solitaireGame.tableauPiles[3].GetCount(), solitaireGame.cards[3], 3);
            }
            if (tableau == 4) {
                DisplayGuiTableau(solitaireGame.tableauPiles[4], tableauPile4, solitaireGame.tableauPiles[4].GetCount(), solitaireGame.cards[4], 4);
            }
            if (tableau == 5) {
                DisplayGuiTableau(solitaireGame.tableauPiles[5], tableauPile5, solitaireGame.tableauPiles[5].GetCount(), solitaireGame.cards[5], 5);
            }
            if (tableau == 6) {
                DisplayGuiTableau(solitaireGame.tableauPiles[6], tableauPile6, solitaireGame.tableauPiles[6].GetCount(), solitaireGame.cards[6], 6);
            }
        }

        private void DisplaySuits() {
            if (solitaireGame.suitPiles[0].GetCount() > 0) {
                Card card = solitaireGame.suitPiles[0].GetLastCardInPile();
                suitPileBoxClub.Image = Images.GetCardImage(card);
            } else {
                suitPileBoxClub.Image = null;
            }
            if (solitaireGame.suitPiles[1].GetCount() > 0) {
                Card card = solitaireGame.suitPiles[1].GetLastCardInPile();
                suitPileBoxDiamond.Image = Images.GetCardImage(card);
            } else {
                suitPileBoxDiamond.Image = null;
            }
            if (solitaireGame.suitPiles[2].GetCount() > 0) {
                Card card = solitaireGame.suitPiles[2].GetLastCardInPile();
                suitPileBoxHeart.Image = Images.GetCardImage(card);
            } else {
                suitPileBoxHeart.Image = null;
            }
            if (solitaireGame.suitPiles[3].GetCount() > 0) {
                Card card = solitaireGame.suitPiles[3].GetLastCardInPile();
                suitPileBoxSpade.Image = Images.GetCardImage(card);
            } else {
                suitPileBoxSpade.Image = null;
            }
        }
        private void DisplayDiscard() {
                if (solitaireGame.discardPile.GetCount() > 0) {
                    Card card = solitaireGame.discardPile.GetLastCardInPile();
                    discardPileBox.Image = Images.GetCardImage(card);
                } else {
                    discardPileBox.Image = null;
                }
        }
        private void DisplayDraw() {
            if (solitaireGame.drawPile.GetCount() > 0) {
                drawPileBox.Image = Images.GetBackOfCardImage();
            } else {
                drawPileBox.Image = null;
            }

        }

        private void TryToPlayCard(Card clickedCard, int clickedTableau) {
            // This MessageBox.Show is for debugging purposes only.
            // comment out line, once sure you can click on a card in a tableau
            //MessageBox.Show(clickedCard.ToString(false, true), "Clicked");
            // Add code to do something with the clicked card.

            //first card clicked
            if (card1 == null) {
                card1 = clickedCard;
                place1 = clickedTableau;

                // clicked ace
                if (card1.ToString(true, false) == "A") {
                    solitaireGame.suitPiles[(int)card1.GetSuit()].Add(card1);
                    solitaireGame.tableauPiles[place1].Remove(card1);
                    if (solitaireGame.tableauPiles[place1].GetCount() - 1 < solitaireGame.cards[place1]) {
                        solitaireGame.cards[place1] = solitaireGame.tableauPiles[place1].GetCount() - 1;
                    }
                    DisplaySuits();
                    DisplayTableaus(place1);
                    card1 = null;
                }

            //second card clicked
            } else {
                card2 = clickedCard;
                place2 = clickedTableau;

                //check if multiple
                if (place1 != 9) {
                    for (int i = 0 ; i < solitaireGame.tableauPiles[place1].GetCount() ; i++) {
                        if (solitaireGame.tableauPiles[place1].GetCard(i) == card1) {
                            cardIndex1 = i;
                        }
                    }
                    if (cardIndex1 < solitaireGame.tableauPiles[place1].GetCount() - 1) {
                        multiple1 = true;
                    } else {
                        multiple1 = false;
                    }
                }
                for (int i = 0 ; i < solitaireGame.tableauPiles[place2].GetCount() ; i++) {
                    if (solitaireGame.tableauPiles[place2].GetCard(i) == card2) {
                        cardIndex2 = i;
                    }
                }
                if (cardIndex2 < solitaireGame.tableauPiles[place2].GetCount() - 1) {
                    multiple2 = true;
                } else {
                    multiple2 = false;
                }

                if (multiple2) {
                    MessageBox.Show("ERROR - Move not allowed - Cannot place card onto this card");
                    card1 = null;
                }
                    //check if can move
                else if (solitaireGame.tryMove(card1, card2)) {

                    //moved from discardPile
                    if (place1 == 9) {
                        solitaireGame.tableauPiles[place2].Add(card1);
                        solitaireGame.discardPile.RemoveLastCard();
                        DisplayDiscard();
                        DisplayTableaus(place2);
                        card1 = null;

                    //moved from tableau
                    } else {
                        if (multiple1) {
                            int currentcount = solitaireGame.tableauPiles[place1].GetCount();
                            for (int i = cardIndex1 ; i < currentcount ; i++) {
                                solitaireGame.tableauPiles[place2].Add(solitaireGame.tableauPiles[place1].GetCard(i));
                            }
                            for (int i = cardIndex1 ; i < currentcount ; i++) {
                                solitaireGame.tableauPiles[place1].RemoveAt(cardIndex1);
                            }
                            if (solitaireGame.tableauPiles[place1].GetCount() - 1 < solitaireGame.cards[place1]) {
                                solitaireGame.cards[place1] = solitaireGame.tableauPiles[place1].GetCount() - 1;
                            }
                        } else {
                            solitaireGame.tableauPiles[place2].Add(card1);
                            solitaireGame.tableauPiles[place1].Remove(card1);
                            if (solitaireGame.tableauPiles[place1].GetCount() - 1 < solitaireGame.cards[place1]) {
                                solitaireGame.cards[place1] = solitaireGame.tableauPiles[place1].GetCount() - 1;
                            }
                        }
                        DisplayTableaus(place1);
                        DisplayTableaus(place2);
                        card1 = null;
                    }

                //failed move
                } else {
                    MessageBox.Show("ERROR - Move not allowed - Cannot place card onto this card");
                    card1 = null;
                }
            }
        }

        private void ClickedEmpty(int tableau) {
            place2 = tableau;
            if (card1 == null) {
            } else {
                if (card1.ToString(true, false) == "K") {

                    //check if multiple
                    if (place1 != 9) {
                        for (int i = 0 ; i < solitaireGame.tableauPiles[place1].GetCount() ; i++) {
                            if (solitaireGame.tableauPiles[place1].GetCard(i) == card1) {
                                cardIndex1 = i;
                            }
                        }
                        if (cardIndex1 < solitaireGame.tableauPiles[place1].GetCount() - 1) {
                            multiple1 = true;
                        } else {
                            multiple1 = false;
                        }
                    }

                    //moved from discardPile
                    if (place1 == 9) {
                        solitaireGame.tableauPiles[place2].Add(card1);
                        solitaireGame.discardPile.RemoveLastCard();
                        DisplayDiscard();
                        DisplayTableaus(place2);
                        card1 = null;

                    //moved from tableau
                    } else {
                        if (multiple1) {
                            int currentcount = solitaireGame.tableauPiles[place1].GetCount();
                            for (int i = cardIndex1 ; i < currentcount ; i++) {
                                solitaireGame.tableauPiles[place2].Add(solitaireGame.tableauPiles[place1].GetCard(i));
                            }
                            for (int i = cardIndex1 ; i < currentcount ; i++) {
                                solitaireGame.tableauPiles[place1].RemoveAt(cardIndex1);
                            }
                            if (solitaireGame.tableauPiles[place1].GetCount() - 1 < solitaireGame.cards[place1]) {
                                solitaireGame.cards[place1] = solitaireGame.tableauPiles[place1].GetCount() - 1;
                            }
                        } else {
                            solitaireGame.tableauPiles[place2].Add(card1);
                            solitaireGame.tableauPiles[place1].Remove(card1);
                            if (solitaireGame.tableauPiles[place1].GetCount() - 1 < solitaireGame.cards[place1]) {
                                solitaireGame.cards[place1] = solitaireGame.tableauPiles[place1].GetCount() - 1;
                            }
                        }
                        DisplayTableaus(place1);
                        DisplayTableaus(place2);
                        card1 = null;
                    }
                }
            }
        }

        private void soilitaireForm_Load(object sender, EventArgs e) {

        }

        private void drawPileBox_Click(object sender, EventArgs e) {
            card1 = null;
            if (solitaireGame.drawPile.GetCount() > 0) {
                solitaireGame.discardPile.Add(solitaireGame.drawPile.DealOneCard());
                DisplayDraw();
                DisplayDiscard();
            } else {
                int count = solitaireGame.discardPile.GetCount();
                for (int i = 0 ; i < count ; i++) {
                    solitaireGame.drawPile.Add(solitaireGame.discardPile.DealOneCard());
                }
                solitaireGame.discardPile.Add(solitaireGame.drawPile.DealOneCard());
                DisplayDraw();
                DisplayDiscard();
            }
        }

        private void discardPileBox_Click(object sender, EventArgs e) {
            if (card1 == null) {
                card1 = solitaireGame.discardPile.GetLastCardInPile();
                place1 = 9;
                if (card1.ToString(true, false) == "A") {
                    solitaireGame.suitPiles[(int)card1.GetSuit()].Add(card1);
                    solitaireGame.discardPile.RemoveLastCard();
                    DisplaySuits();
                    DisplayDiscard();
                    card1 = null;
                }
            } else {
                MessageBox.Show("Cannot place card onto Discard Pile");
                card1 = null;
            }

        }

        private void pictureBox_Click(object sender, EventArgs e) {
            // which card was clicked?
            PictureBox clickedPictureBox = (PictureBox)sender;
            // get a reference to the card
            if ((Card)clickedPictureBox.Tag == null) {
                string tableau = clickedPictureBox.Name;
                currentTableau = Int32.Parse(tableau);
                ClickedEmpty(currentTableau);
            } else {
                Card clickedCard = (Card)clickedPictureBox.Tag;
                for (int i = 0 ; i <= 6 ; i++) {
                    if (solitaireGame.tableauPiles[i].Contains(clickedCard)) {
                        currentTableau = i;
                    }
                }
                TryToPlayCard(clickedCard, currentTableau);
            }
        }

        private void moveSuit (int suit) {
            if (card1 == null) {
            } else {

                //check right suit
                if ((int)card1.GetSuit() == suit) {

                    //check right card
                    if (solitaireGame.tryScore(card1, suit)) {

                        //check if multiple
                        if (place1 != 9) {
                            for (int i = 0 ; i < solitaireGame.tableauPiles[place1].GetCount() ; i++) {
                                if (solitaireGame.tableauPiles[place1].GetCard(i) == card1) {
                                    cardIndex1 = i;
                                }
                            }
                            if (cardIndex1 < solitaireGame.tableauPiles[place1].GetCount() - 1) {
                                multiple1 = true;
                            } else {
                                multiple1 = false;
                            }
                        }

                        //move the card
                        if (multiple1 == false) {
                            if (place1 == 9) {
                                solitaireGame.suitPiles[suit].Add(card1);
                                solitaireGame.discardPile.RemoveLastCard();
                                DisplayDiscard();
                                DisplaySuits();
                            } else {
                                solitaireGame.suitPiles[suit].Add(card1);
                                solitaireGame.tableauPiles[place1].Remove(card1);
                                if (solitaireGame.tableauPiles[place1].GetCount() - 1 < solitaireGame.cards[place1]) {
                                    solitaireGame.cards[place1] = solitaireGame.tableauPiles[place1].GetCount() - 1;
                                }
                                DisplayTableaus(place1);
                                DisplaySuits();
                            }
                            if ((int)card1.GetFaceValue() == 11 ) {
                                if (solitaireGame.checkWon(suit)) {
                                    MessageBox.Show("Congratulation, you won!!");
                                }
                            }
                            card1 = null;
                        } else {
                            MessageBox.Show("ERROR - Move not allowed - Cannot place card onto this card");
                        }
                    } else {
                        MessageBox.Show("ERROR - Move not allowed - Cannot place card onto this card");
                    }
                } else {
                    MessageBox.Show("ERROR - Move not allowed - Cannot place card onto this card");
                }
            }

        }
        private void suitPileBoxClub_Click(object sender, EventArgs e) {
            moveSuit(0);
        }


        private void suitPileBoxDiamond_Click(object sender, EventArgs e) {
            moveSuit(1);
        }

        private void suitPileBoxHeart_Click(object sender, EventArgs e) {
            moveSuit(2);
        }

        private void suitPileBoxSpade_Click(object sender, EventArgs e) {
            moveSuit(3);
        }
    }
}
