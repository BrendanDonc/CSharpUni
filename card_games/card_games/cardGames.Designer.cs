namespace card_games
{
    partial class cardGames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseLabel = new System.Windows.Forms.Label();
            this.cardCombo = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.Location = new System.Drawing.Point(70, 63);
            this.chooseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(302, 30);
            this.chooseLabel.TabIndex = 0;
            this.chooseLabel.Text = "Choose a Game to play";
            // 
            // cardCombo
            // 
            this.cardCombo.FormattingEnabled = true;
            this.cardCombo.Items.AddRange(new object[] {
            "",
            "Solitaire",
            "Twenty One"});
            this.cardCombo.Location = new System.Drawing.Point(130, 132);
            this.cardCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardCombo.Name = "cardCombo";
            this.cardCombo.Size = new System.Drawing.Size(180, 28);
            this.cardCombo.TabIndex = 1;
            this.cardCombo.SelectedIndexChanged += new System.EventHandler(this.cardCombo_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(148, 240);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 77);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cardGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 485);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cardCombo);
            this.Controls.Add(this.chooseLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cardGames";
            this.Text = "cardGames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.ComboBox cardCombo;
        private System.Windows.Forms.Button exitButton;
    }
}