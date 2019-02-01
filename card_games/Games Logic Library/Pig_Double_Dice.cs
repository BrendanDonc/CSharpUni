using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public class Pig_Double_Dice {
        private Die die = new Die();
        public Die[] dice = new Die[2];
        public int[] faceValue = { 0, 0 };
        public int[] pointsTotal = { 0, 0 };
        public string[] playersName = { "", "" };
        private int currentPlayer = 0;

        public void SetUpGame() {
            dice[0] = new Die();
            dice[1] = new Die();
            faceValue[0] = 0;
            faceValue[1] = 0;
            pointsTotal[0] = 0;
            pointsTotal[1] = 0;
            playersName[0] = "Player One";
            playersName[1] = "Player Two";
        }

        public bool PlayGame() {
            die.RollDie();
            faceValue[0] = die.GetFaceValue();
            die.RollDie();
            faceValue[1] = die.GetFaceValue();
            if (faceValue[0] == 1 && faceValue[1] == 1) {
                pointsTotal[currentPlayer] = pointsTotal[currentPlayer] + 25;
                return false;
            } else if (faceValue[0] == 2 && faceValue[1] == 2) {
                pointsTotal[currentPlayer] = pointsTotal[currentPlayer] + 8;
                return false;
            } else if (faceValue[0] == 3 && faceValue[1] == 3) {
                pointsTotal[currentPlayer] = pointsTotal[currentPlayer] + 12;
                return false;
            } else if (faceValue[0] == 4 && faceValue[1] == 4) {
                pointsTotal[currentPlayer] = pointsTotal[currentPlayer] + 16;
                return false;
            } else if (faceValue[0] == 5 && faceValue[1] == 5) {
                pointsTotal[currentPlayer] = pointsTotal[currentPlayer] + 20;
                return false;
            } else if (faceValue[0] == 6 && faceValue[1] == 6) {
                pointsTotal[currentPlayer] = pointsTotal[currentPlayer] + 24;
                return false;
            } else if (faceValue[0] == 1 || faceValue[1] == 1) {
                return true;
            } else {
                pointsTotal[currentPlayer] = pointsTotal[currentPlayer] + faceValue[0] + faceValue[1];
                return false;
            }


        }

        public bool HasWon() {
            if (pointsTotal[currentPlayer] >= 100) {
                return true;
            } else {
                return false;
            }
        }

        public string GetFirstPlayersName() {
            return playersName[currentPlayer];
        }

        public string GetNextPlayersName() {
            currentPlayer = (currentPlayer + 1) % 2;
            return playersName[currentPlayer];
        }

        public int GetPointsTotal(string nameOfPlayer) {
            if (nameOfPlayer == "Player One") {
                return pointsTotal[0];
            } else if (nameOfPlayer == "Player Two") {
                return pointsTotal[1];
            }
            return 1;
        }

        public int GetFaceValue(int whichDie) {
            if (whichDie == 0) {
                return faceValue[0];
            } else if (whichDie == 1) {
                return faceValue[1];
            }
            return 1;
        }




    }
}
