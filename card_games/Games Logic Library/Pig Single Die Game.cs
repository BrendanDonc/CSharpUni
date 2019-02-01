using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public class Pig_Single_Die_Game {

        private Die die = new Die();
        private int faceValue;
        private int currentPlayer;
        private int turnPoints;
        private int[] pointsTotal = { 0, 0 };
        private string[] playersName = { "", "" };

        public void SetUpGame() {
            playersName[0] = "Player 1";
            pointsTotal[0] = 0;
            playersName[1] = "Player 2";
            pointsTotal[1] = 0;
            faceValue = die.GetFaceValue();
            currentPlayer = 0;
            turnPoints = 0;
        }

        public bool PlayGame() {
            die.RollDie();
            faceValue = GetFaceValue();
            if (faceValue == 1) {
                pointsTotal[currentPlayer] = pointsTotal[currentPlayer] - turnPoints;
                return true;
            } else {
                turnPoints = turnPoints + GetFaceValue();
                return false;
            }
        }

        public bool HasWon() {
            if (pointsTotal[currentPlayer] + turnPoints >= 30) {
                return true;
            } else {
                return false;
            }
        }

        public string GetFirstPlayerName() {
            return playersName[currentPlayer];
        }

        public string GetNextPlayerName() {
            pointsTotal[currentPlayer] = pointsTotal[currentPlayer] + turnPoints;
            currentPlayer = (currentPlayer + 1) % 2;
            turnPoints = 0;
            return playersName[currentPlayer];
        }

        public int GetPointsTotal(string nameOfPlayer) {
            if (nameOfPlayer == "Player 1") {
                if (currentPlayer == 0) {
                    return pointsTotal[0] + turnPoints;
                } else {
                    return pointsTotal[1];
                }
            } else {
                if (currentPlayer == 1) {
                    return pointsTotal[1] + turnPoints;
                } else {
                    return pointsTotal[0];
                }
            }
        }

        public int GetFaceValue() {
            return die.GetFaceValue();
        }

    }
}
