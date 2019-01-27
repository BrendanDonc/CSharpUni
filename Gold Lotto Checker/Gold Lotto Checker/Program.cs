using System;

namespace Gold_Lotto_Checker {

    ///<summary>
    ///
    ///Program which takes pre-input arrays of lotto numbers
    ///and drawn numbers then displays all numbers in the
    ///console as well as how many winning and supplementary
    ///numbers each lotto array has within.
    ///
    ///Author Brendan Doncaster n9819363 April 2017
    ///
    ///</summary>

    class Program {

        static void Main() {

            int[,] lottoNumbers = {
                                  { 4, 7, 19, 23, 28, 36},
                                  {14, 18, 26, 34, 38, 45},
                                  { 8, 10,11, 19, 28, 30},
                                  {15, 17, 19, 24, 43, 44},
                                  {10, 27, 29, 30, 32, 41},
                                  { 9, 13, 26, 32, 37,  43},
                                  { 1, 3, 25, 27, 35, 41},
                                  { 7, 9, 17, 26, 28, 44},
                                  {17, 18, 20, 28, 33, 38}
                              };

            int[] drawNumbers = new int[] { 44, 9, 17, 43, 26, 7, 28, 19 };
            int games;

            Welcome();
            games = GetNumGames(lottoNumbers);       
            PrintGames(lottoNumbers, games);
            PrintDraw(drawNumbers);
            PrintResults(games, drawNumbers, lottoNumbers);

            ExitProgram();
        }//end Main

        /// <summary>
        /// 
        /// Gets the number of lotto games from the list of lotto numbers
        /// 
        /// </summary>
        /// <param name="lottoNumbers">List of lotto numbers input into code</param>
        /// <returns>Number of different games within lottoNumbers</returns>

        static int GetNumGames(int[,] lottoNumbers) {
            int games = lottoNumbers.GetUpperBound(0);
            return games;
        }//end GetNumGames

        /// <summary>
        /// 
        /// Displays welcome message
        /// 
        /// </summary>

        static void Welcome() {
            Console.WriteLine("\n\tWelcome to Lotto Checker\n\n");
        }//end Welcome

        /// <summary>
        /// 
        /// Prints out the lotto numbers with a new line per game
        /// 
        /// </summary>
        /// <param name="lottoNumbers">List of lotto numbers input into code</param>
        /// <param name="games">Number of different games within lottoNumbers</param>

        static void PrintGames(int[,] lottoNumbers, int games) {
            Console.Write("\nYour Lotto numbers are");
            for (int i = 0; i <= games; i++) {
                Console.Write("\nGame   "+(i+1) + ":");
                for (int j = 0; j <= 5; j++) {
                    if(lottoNumbers[i,j] >= 10) {
                        Console.Write("  " + lottoNumbers[i,j]);
                    } else {
                        Console.Write("   " + lottoNumbers[i,j]);
                    }
                }
                Console.Write("\n");
            }
        }//end PrintGames

        /// <summary>
        /// 
        /// Prints out the drawn numbers
        /// 
        /// </summary>
        /// <param name="drawNumbers">List of winning and supplementary numbers</param>

        static void PrintDraw(int[] drawNumbers) {
            Console.Write("\n\n\n Lotto Draw Numbers are\n\n ");
            for (int i = 0; i <= 7; i++) {
                if (drawNumbers[i] >= 10) {
                            Console.Write("  " + drawNumbers[i]);
                } else {
                    Console.Write("   " + drawNumbers[i]);
                }
            }
        }//end PrintDraw

        /// <summary>
        /// 
        /// Prints the amount of winning numbers and supplementary numbers for each game
        /// 
        /// </summary>
        /// <param name="games">Number of different games within lottoNumbers</param>
        /// <param name="drawNumbers">List of winning and supplementary numbers</param>
        /// <param name="lottoNumbers">List of lotto numbers input into code</param>

        static void PrintResults(int games, int[] drawNumbers, int[,] lottoNumbers) {
            int winNum;
            int suppNum;


            for (int i = 0; i <= games; i++) {
                winNum = FindWinners(i, drawNumbers, lottoNumbers);
                suppNum = FindSupps(i, drawNumbers, lottoNumbers);
                Console.WriteLine("\n\n\tfound " + winNum + " winning numbers and "
                    + suppNum + " supplementary numbers in game " + (i+1) + "\n");
            }
        }//end PrintResults

        /// <summary>
        /// 
        /// Gets the number of winning numbers for the current game
        /// 
        /// </summary>
        /// <param name="game">Current game</param>
        /// <param name="drawNumbers">List of winning and supplementary numbers</param>
        /// <param name="lottoNumbers">List of lotto numbers input into code</param>
        /// <returns>Number of winning numbers</returns>

        static int FindWinners(int game, int[] drawNumbers, int[,] lottoNumbers) {
            int wins = 0;
            for (int i = 0; i <= 5; i++) {
                for (int j = 0; j <= 5; j++) {
                    if (lottoNumbers[game,i] == drawNumbers[j]) {
                        wins = wins + 1;
                    }
                }
            }
            return wins;
        }//end FindWinners

        /// <summary>
        /// 
        /// Gets the number of supplementary numbers for the current game
        /// 
        /// </summary>
        /// <param name="game">Current game</param>
        /// <param name="drawNumbers">List of winning and supplementary numbers</param>
        /// <param name="lottoNumbers">List of lotto numbers input into code</param>
        /// <returns>Number of supplementary numbers</returns>

        static int FindSupps(int game, int[] drawNumbers, int[,] lottoNumbers) {
            int supps = 0;
            for (int i = 0; i <= 5; i++) {
                for (int j = 6; j <= 7; j++) {
                    if (lottoNumbers[game,i] == drawNumbers[j]) {
                        supps = supps + 1;
                    }
                }
            }
            return supps;
        }//end FindSupps


        /// <summary>
        /// 
        /// Displays the exit message and exits program on any key
        /// 
        /// </summary>

        static void ExitProgram() {
            Console.WriteLine("\n\n\t Thanks for using Lotto Checker");
            Console.Write("\n\nPress any key to exit program: ");
            Console.ReadKey();
        }//end ExitProgram



    }//end class
}//end namespace
