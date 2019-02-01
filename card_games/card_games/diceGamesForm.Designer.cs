namespace card_games
{
    partial class diceGamesForm
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
            this.selectLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.twoRdioBtn = new System.Windows.Forms.RadioButton();
            this.SingleRdioBtn = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.Location = new System.Drawing.Point(26, 0);
            this.selectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(211, 20);
            this.selectLabel.TabIndex = 0;
            this.selectLabel.Text = "Select which Pig to play";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.twoRdioBtn);
            this.groupBox1.Controls.Add(this.SingleRdioBtn);
            this.groupBox1.Controls.Add(this.selectLabel);
            this.groupBox1.Location = new System.Drawing.Point(58, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // twoRdioBtn
            // 
            this.twoRdioBtn.AutoSize = true;
            this.twoRdioBtn.Location = new System.Drawing.Point(30, 95);
            this.twoRdioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.twoRdioBtn.Name = "twoRdioBtn";
            this.twoRdioBtn.Size = new System.Drawing.Size(125, 24);
            this.twoRdioBtn.TabIndex = 2;
            this.twoRdioBtn.Text = "Two Dice Pig";
            this.twoRdioBtn.UseVisualStyleBackColor = true;
            this.twoRdioBtn.CheckedChanged += new System.EventHandler(this.twoRdioBtn_CheckedChanged);
            // 
            // SingleRdioBtn
            // 
            this.SingleRdioBtn.AutoSize = true;
            this.SingleRdioBtn.Location = new System.Drawing.Point(30, 46);
            this.SingleRdioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SingleRdioBtn.Name = "SingleRdioBtn";
            this.SingleRdioBtn.Size = new System.Drawing.Size(140, 24);
            this.SingleRdioBtn.TabIndex = 2;
            this.SingleRdioBtn.Text = "Single Dice Pig";
            this.SingleRdioBtn.UseVisualStyleBackColor = true;
            this.SingleRdioBtn.CheckedChanged += new System.EventHandler(this.SingleRdioBtn_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(88, 260);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 43);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // diceGamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 322);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "diceGamesForm";
            this.Text = "Dice Games";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton twoRdioBtn;
        private System.Windows.Forms.RadioButton SingleRdioBtn;
    }
}