using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public class Solitaire_Game {
        public CardPile drawPile;
        public CardPile discardPile;
        public Hand[] tableauPiles = new Hand[7];
        public CardPile[] suitPiles = new CardPile[4];
        public int[] cards = new int[7];
        public bool[] won = new bool[4];
        public int winning;

        /// <summary>
        /// Initializes the class variables at start of a new game
        /// </summary>
        public void SetUpGame() {
            drawPile = new CardPile(true);
            discardPile = new CardPile(false);
            //discardPile.Add(drawPile.DealOneCard());
            drawPile.Shuffle();
            for (int i = 0 ; i <= 6 ; i++) {
                tableauPiles[i] = new Hand(drawPile.DealCards(1 + i));
                cards[i] = i;
            }
            for (int i = 0 ; i <= 3 ; i++) {
                suitPiles[i] = new CardPile(false);
                won[i] = false;
            }

        }

        /// <summary>
        /// returns true if card 1 moving to card 2 is a valid move
        /// </summary>
        /// <param name="card1">Card that is being moved</param>
        /// <param name="card2">Card that it is being moved to</param>
        /// <returns></returns>
        public bool tryMove(Card card1, Card card2) {
            if (card2.GetFaceValue() - card1.GetFaceValue() == 1) {
                if ((int)card1.GetSuit() == 0 || (int)card1.GetSuit() == 3) {
                    if ((int)card2.GetSuit() == 1 || (int)card2.GetSuit() == 2) {
                        return true;
                    } else {
                        return false;
                    }
                } else {
                    if ((int)card2.GetSuit() == 0 || (int)card2.GetSuit() == 3) {
                        return true;
                    } else {
                        return false;
                    }
                }
            } else {
                return false;
            }
        }

        /// <summary>
        /// returns true if card being moved to suit pile is a valid move
        /// </summary>
        /// <param name="card">card being moved</param>
        /// <param name="suit">int representing suit type</param>
        /// <returns></returns>
        public bool tryScore(Card card, int suit) {
            Card suitCard = suitPiles[suit].GetLastCardInPile();
            int suitNum = (int)suitCard.GetFaceValue() + 1;
            if ((int)suitCard.GetFaceValue() == 12) {
                suitNum = 0;
            }
            int cardNum = (int)card.GetFaceValue() + 1;
            if (cardNum - suitNum == 1) {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// return true if all 4 suit piles are full
        /// </summary>
        /// <param name="suit">suit that just won</param>
        /// <returns></returns>
        public bool checkWon(int suit) {
            won[suit] = true;
            winning = 0;
            for (int i = 0 ; i <= 3 ; i++) {
                if (won[i]) {
                    winning++;
                }
            }
            if (winning == 4) {
                return true;
            } else {
                return false;
            }
        }

    }
}
