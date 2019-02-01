namespace card_games
{
    partial class mainMenu
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.DiceRdioBtn = new System.Windows.Forms.RadioButton();
            this.cardRdioBtn = new System.Windows.Forms.RadioButton();
            this.startBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(66, 92);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(291, 37);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Interactive Games";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // DiceRdioBtn
            // 
            this.DiceRdioBtn.AutoSize = true;
            this.DiceRdioBtn.Location = new System.Drawing.Point(112, 251);
            this.DiceRdioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiceRdioBtn.Name = "DiceRdioBtn";
            this.DiceRdioBtn.Size = new System.Drawing.Size(114, 24);
            this.DiceRdioBtn.TabIndex = 2;
            this.DiceRdioBtn.TabStop = true;
            this.DiceRdioBtn.Text = "Dice Game";
            this.DiceRdioBtn.UseVisualStyleBackColor = true;
            this.DiceRdioBtn.CheckedChanged += new System.EventHandler(this.DiceRdioBtn_CheckedChanged);
            // 
            // cardRdioBtn
            // 
            this.cardRdioBtn.AutoSize = true;
            this.cardRdioBtn.Location = new System.Drawing.Point(112, 309);
            this.cardRdioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardRdioBtn.Name = "cardRdioBtn";
            this.cardRdioBtn.Size = new System.Drawing.Size(116, 24);
            this.cardRdioBtn.TabIndex = 3;
            this.cardRdioBtn.TabStop = true;
            this.cardRdioBtn.Text = "Card Game";
            this.cardRdioBtn.UseVisualStyleBackColor = true;
            this.cardRdioBtn.CheckedChanged += new System.EventHandler(this.cardRdioBtn_CheckedChanged);
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(117, 463);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(164, 42);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(117, 542);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(164, 38);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Location = new System.Drawing.Point(90, 201);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(220, 164);
            this.gameGroupBox.TabIndex = 6;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Select Game Type";
            this.gameGroupBox.Enter += new System.EventHandler(this.gameGroupBox_Enter);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 700);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.cardRdioBtn);
            this.Controls.Add(this.DiceRdioBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.gameGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainMenu";
            this.Text = "Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.RadioButton DiceRdioBtn;
        private System.Windows.Forms.RadioButton cardRdioBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox gameGroupBox;
    }
}

