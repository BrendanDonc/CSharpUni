using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card_games
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void startBtn_Click(object sender, EventArgs e)
        {

            //MainMenu Creation
            mainMenu mainMenuForm = new mainMenu();

            //Dice Games Form creation
            diceGamesForm diceForm = new diceGamesForm();

            //Card Games Form Creation
            cardGames cardForm = new cardGames();

            if (DiceRdioBtn.Checked)
            {
                diceForm.Show();
                this.Hide();
                

            }
            else if (cardRdioBtn.Checked) {
                cardForm.Show();
                this.Hide();
            }
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Do you wish to exit the program?", "Exit", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes) {
                Application.Exit();
            } else if (Exit == DialogResult.No) {
            }
        }

        private void gameGroupBox_Enter(object sender, EventArgs e) {
        }

        private void DiceRdioBtn_CheckedChanged(object sender, EventArgs e) {
            startBtn.Enabled = true;
        }

        private void cardRdioBtn_CheckedChanged(object sender, EventArgs e) {
            startBtn.Enabled = true;
        }
    }
}
