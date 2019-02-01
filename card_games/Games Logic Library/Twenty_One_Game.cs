using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public class Twenty_One_Game {

        public CardPile cardPile;
        public Hand[] hands = new Hand[2];
        public Hand[] addToMe = new Hand[2];
        public int[] totalPoints = { 0, 0 };
        public int[] numOfGamesWon = { 0, 0 };
        private int numOfUserAcesWithValueOne;
        private bool endGame = false;

        public int[] totalWins = { 0, 0 };
        private int aceNumberTotal;
        private int aceChoice;
        public void SetUpGame() {
            cardPile = new CardPile(true);
            cardPile.Shuffle();
            hands[0] = new Hand(cardPile.DealCards(2));
            hands[1] = new Hand(cardPile.DealCards(2));
            addToMe[0] = new Hand();
            addToMe[1] = new Hand();
            totalPoints[0] = 0;
            totalPoints[1] = 0;

            numOfGamesWon[0] = 0;
            numOfGamesWon[1] = 0;
            aceChoice = 0;
            endGame = false;
            numOfUserAcesWithValueOne = 0;
            numOfUserAcesWithValueOne = 0;
        }

        public Card DealOneCardTo(int who) {
            Card dealt = cardPile.DealOneCard();
            hands[who].Add(cardPile.DealOneCard());
            return dealt;
        }

        public int CalculateHandTotal(int who) {
            int currentHand = hands[who].GetCount();
            string currentValue = "";
            int totalHand = 0;
            for (int i = 0 ; i < currentHand ; i++) {
                currentValue = hands[who].GetCard(i).ToString(true, false);
                if (currentValue == "2") {
                    totalHand = totalHand + 2;

                } else if (currentValue == "3") {
                    totalHand = totalHand + 3;
                } else if (currentValue == "4") {
                    totalHand = totalHand + 4;
                } else if (currentValue == "5") {
                    totalHand = totalHand + 5;
                } else if (currentValue == "6") {
                    totalHand = totalHand + 6;
                } else if (currentValue == "7") {
                    totalHand = totalHand + 7;
                } else if (currentValue == "8") {
                    totalHand = totalHand + 8;
                } else if (currentValue == "9") {
                    totalHand = totalHand + 9;
                } else if (currentValue == "10") {
                    totalHand = totalHand + 10;
                } else if (currentValue == "A") {
                    totalHand = totalHand + 11;
                } else {
                    totalHand = totalHand + 10;
                }

            }
            return totalHand;
        }

        public void PlayForDealer() {
            hands[1].Add(cardPile.DealOneCard());
        }

        public Hand GetHand(int who) {
            return hands[who];
        }

        public int GetTotalPoints(int who) {
            int currentTotal = 0;
            if (who == 0) {
                currentTotal = CalculateHandTotal(0);
                return currentTotal;
            } else {
                currentTotal = CalculateHandTotal(1);
                return currentTotal;
            }

        }

        public bool IsItAce(int who) {
            int currentHand = hands[who].GetCount();
            string currentValue = "";
            int totalHand = 0;
            for (int i = 0 ; i < currentHand ; i++) {
                currentValue = hands[who].GetCard(i).ToString(true, false);
                if (currentValue == "A") {
                    return true;
                }
            }
            return false;
        }

        public int GetNumOfGamesWon(int who) {
            int currentHand = CalculateHandTotal(who);
            return currentHand;
        }

        public int GetNumberOfUserAces() {
            return aceNumberTotal;
        }

        public int IncrementNumOfUserAcesWithValueOne() {
            if (aceChoice == 1) {
                aceNumberTotal += 1;
                return aceNumberTotal;
            } else {
                return aceNumberTotal;
            }
        }

        public void ResetTotals() {
            cardPile = new CardPile(true);
            cardPile.Shuffle();
            hands[0] = new Hand(cardPile.DealCards(2));
            hands[1] = new Hand(cardPile.DealCards(2));
            addToMe[0] = new Hand();
            addToMe[1] = new Hand();
            totalPoints[0] = 0;
            totalPoints[1] = 0;

            numOfGamesWon[0] = 0;
            numOfGamesWon[1] = 0;
            aceChoice = 0;
            endGame = false;
            numOfUserAcesWithValueOne = 0;
            numOfUserAcesWithValueOne = 0;
        }



    }
}
