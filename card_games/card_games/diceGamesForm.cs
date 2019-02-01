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
    public partial class diceGamesForm : Form
    {
        public diceGamesForm()
        {
            InitializeComponent();
            


        }

        private void SingleRdioBtn_CheckedChanged(object sender, EventArgs e)
        {
            PigGameForm singleDiceForm = new PigGameForm();
            if (SingleRdioBtn.Checked) {
                singleDiceForm.Show();
                this.Hide();
            }

        }

        private void twoRdioBtn_CheckedChanged(object sender, EventArgs e)
        {
            pigWithTwoDice twoDiceForm = new pigWithTwoDice();
            if (twoRdioBtn.Checked) {
                twoDiceForm.Show();
                this.Hide();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Do you wish to exit the program?", "Exit", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes) {
                mainMenu mainMenuForm = new mainMenu();
                mainMenuForm.Show();
                this.Hide();
            } else if (Exit == DialogResult.No) {
            }
        }
    }
}
