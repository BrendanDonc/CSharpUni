using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTH {
    /// <summary>
    /// 
    /// Menu driven program which calculates
    /// the waist-height ratio and gives
    /// the degree of risk for cardiovascular 
    /// disease based on the given gender.
    /// 
    /// Author Brendan Doncaster March 2017
    /// 
    /// 
    /// </summary>
    class WTH {
        static void Main(string[] args) {

        int waist;
        int height;
        int gender;
        double ratio;
        bool recalculate = true;

        WelcomeMessage();

        while (recalculate == true) {
        waist = ReadWaist();
        height = ReadHeight();
        GenderMenu();
        gender = ReadOption();
        ratio = PerformRatio(waist, height);
        PerformRisk(gender, ratio);
        recalculate = Recalc();
        }

        ExitProgram();
        }//end Main


        /// <summary>
        /// 
        /// Displays the greeting 
        /// message/title for the program.
        /// 
        /// </summary>
        static void WelcomeMessage() {
        Console.WriteLine("\n\tWelcome to Waist to Height Ratio Calculator\n");
        }//end WelcomeMessage


        /// <summary>
        /// 
        /// Asks the user for their
        /// waist measurement (cm) to be input.
        /// Also checks for measurement's validity.
        /// 
        /// </summary>
        /// <returns> Waist measurement</returns>
        static int ReadWaist() {
        string input;
        int waist;
        bool isInt;
        bool okayInput;

        //Asks for an input and checks if it is a number that is at least 60
        do {
        Console.Write("\nEnter waist measurement in cm: ");
        input = Console.ReadLine();
        isInt = int.TryParse(input, out waist);
        if (!isInt) {
        okayInput = false;
        }
        else if (waist < 60) {
        okayInput = false;
        }
        else {
        okayInput = true;
        }
        if (!okayInput) {
        Console.WriteLine("You did not enter a valid measurement.\n\n Please try again");
        }
        } while (!okayInput);

        return waist;
        }//end ReadWaist


        /// <summary>
        /// 
        /// Asks the user for their
        /// height measurement (cm) to be input.
        /// Also checks for measurement's validity.
        /// 
        /// </summary>
        /// <returns> Height measurement</returns>
        static int ReadHeight() {
        string input;
        int height;
        bool isInt;
        bool okayInput;

        //Asks for an input and checks if it is a number that is at least 120
        do {
        Console.Write("\nEnter height measurement in cm: ");
        input = Console.ReadLine();
        isInt = int.TryParse(input, out height);
        if (!isInt) {
        okayInput = false;
        }
        else if (height < 120) {
        okayInput = false;
        }
        else {
        okayInput = true;
        }
        if (!okayInput) {
        Console.WriteLine("\n\n\tmeasurement must be at least 120cm");
        }
        } while (!okayInput);

        return height;

        }//end ReadHeight


        /// <summary>
        /// 
        /// Displays a menu option for the
        /// user to input their gender.
        /// 
        /// </summary>
        static void GenderMenu() {
        string menu = "\nAre you"
                    + "\n\t1> male"
                    + "\n\t2> female"
                    + "\n\n\tEnter your option <1 or 2>: ";

        Console.Write(menu);
        } //end GenderMenu


        /// <summary>
        /// 
        /// Reads the gender option chosen during
        /// GenderMenu and checks response for 
        /// validity. Re-runs GenderMenu if 
        /// validity check is failed.
        /// 
        /// </summary>
        /// <returns>Gender choice as 1 or 2 if response was valid.</returns>
        static int ReadOption() {
        string choice;
        int option;
        bool isInt;
        bool okayChoice;

        //Checks if user input is a number and if it is either '1' or '2'
        do {
        choice = Console.ReadLine();
        isInt = int.TryParse(choice, out option);

        if (!isInt) {
        okayChoice = false;
        }
        else if (option != 1 && option != 2) {
        okayChoice = false;
        }
        else {
        okayChoice = true;
        }

        if (!okayChoice) {
        Console.WriteLine("You did not enter a correct option.\n\n Please try again");
        GenderMenu();
        }
        } while (!okayChoice);

        return option;
        } //end ReadOption


        /// <summary>
        /// 
        /// Calculates the waist to height ratio
        /// based off of supplied measurements.
        /// 
        /// </summary>
        /// <param name="waist">Waist measurement supplied by user</param>
        /// <param name="height">Height measurement supplied by user</param>
        /// <returns>Calculated waist to height ratio</returns>
        static double PerformRatio(int waist, int height) {
        double waistDouble = waist;
        double heightDouble = height;
        double ratio = (waistDouble / heightDouble);
        ratio = Math.Round(ratio, 3);
        return ratio;
        }//end PerformRatio


        /// <summary>
        /// 
        ///Uses defined risk threshholds per
        ///gender to assess the degree of risk for 
        ///cardiovascular disease.
        ///
        /// </summary>
        /// <param name="gender">Gender representation, 
        ///1 being for male and 2 being for female.</param>
        /// <param name="ratio">Waist to heigh ratio</param>
        static void PerformRisk(int gender, double ratio) {
        if (gender == 1) {
        if (ratio < 0.536) {
        Console.WriteLine("\nYour waist to height ratio is " + ratio
            + "\n\tand\n you are at a low risk of developing obesity related cardiovascular diseases.");
        }
        else {
        Console.WriteLine("\nYour waist to height ratio is " + ratio
            + "\n\tand\n you are at a high risk of developing obesity related cardiovascular diseases.");
        }
        }
        else if (gender == 2) {
        if (ratio < 0.492) {
        Console.WriteLine("\nYour waist to height ratio is " + ratio
            + "\n\tand\n you are at a low risk of developing obesity related cardiovascular diseases.");
        }
        else {
        Console.WriteLine("\nYour waist to height ratio is " + ratio
            + "\n\tand\n you are at a high risk of developing obesity related cardiovascular diseases.");
        }
        }
        else {
        Console.WriteLine("\nError calculating risk. \n\n Please try again");
        }
        }//end PerformRisk


        /// <summary>
        /// 
        /// Asks the user if they wish to run the
        /// calculation process again.
        /// 
        /// </summary>
        /// <returns>True if user wishes to rerun the program</returns>
        static bool Recalc() {
        string choice;
        Console.Write("\n\nAnother calculation <Enter Y or N>:");
        choice = Console.ReadLine();
        if (choice == "Y" || choice == "y") {
        return true;
        }
        else {
        return false;
        }

        }//end Recalc


        /// <summary>
        /// 
        /// Terminates the program gracefully with a press any key.
        /// 
        /// </summary>
        static void ExitProgram() {
        Console.Write("\n\nPress any key to terminate program ...");
        Console.ReadKey();
        }//end ExitProgram
    }
}
