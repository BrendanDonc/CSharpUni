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
    public partial class cardGames : Form
    {
        public cardGames()
        {
            InitializeComponent();
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



        private void cardCombo_SelectedIndexChanged(object sender, EventArgs e) {
            if (cardCombo.SelectedIndex == 1) {
                solitaireForm solitaire = new solitaireForm();
                this.Hide();
                solitaire.Show();
            }
            if (cardCombo.SelectedIndex == 2) {
                z twentyOne = new z();
                this.Hide();
                twentyOne.Show();
            }
        }
    }
}
