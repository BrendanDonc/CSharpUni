namespace card_games
{
    partial class PigGameForm
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
            this.anotherGroup = new System.Windows.Forms.GroupBox();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.holdButton = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.p2TotalLabel = new System.Windows.Forms.Label();
            this.p1TotalLabel = new System.Windows.Forms.Label();
            this.rollHoldLabel = new System.Windows.Forms.Label();
            this.whoseTurnLabel = new System.Windows.Forms.Label();
            this.diePicture = new System.Windows.Forms.PictureBox();
            this.p1TotalBox = new System.Windows.Forms.TextBox();
            this.p2TotalBox = new System.Windows.Forms.TextBox();
            this.anotherGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // anotherGroup
            // 
            this.anotherGroup.Controls.Add(this.noRadio);
            this.anotherGroup.Controls.Add(this.yesRadio);
            this.anotherGroup.Enabled = false;
            this.anotherGroup.Location = new System.Drawing.Point(203, 99);
            this.anotherGroup.Margin = new System.Windows.Forms.Padding(2);
            this.anotherGroup.Name = "anotherGroup";
            this.anotherGroup.Padding = new System.Windows.Forms.Padding(2);
            this.anotherGroup.Size = new System.Drawing.Size(95, 90);
            this.anotherGroup.TabIndex = 15;
            this.anotherGroup.TabStop = false;
            this.anotherGroup.Text = "Another Game?";
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Location = new System.Drawing.Point(21, 52);
            this.noRadio.Margin = new System.Windows.Forms.Padding(2);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(39, 17);
            this.noRadio.TabIndex = 1;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            this.noRadio.CheckedChanged += new System.EventHandler(this.noRadio_CheckedChanged);
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Location = new System.Drawing.Point(21, 28);
            this.yesRadio.Margin = new System.Windows.Forms.Padding(2);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(43, 17);
            this.yesRadio.TabIndex = 0;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            this.yesRadio.CheckedChanged += new System.EventHandler(this.yesRadio_CheckedChanged);
            // 
            // holdButton
            // 
            this.holdButton.BackColor = System.Drawing.Color.Red;
            this.holdButton.Enabled = false;
            this.holdButton.Location = new System.Drawing.Point(105, 125);
            this.holdButton.Margin = new System.Windows.Forms.Padding(2);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(67, 21);
            this.holdButton.TabIndex = 14;
            this.holdButton.Text = "Hold";
            this.holdButton.UseVisualStyleBackColor = false;
            this.holdButton.Click += new System.EventHandler(this.holdButton_Click);
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.Lime;
            this.rollButton.Location = new System.Drawing.Point(31, 125);
            this.rollButton.Margin = new System.Windows.Forms.Padding(2);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(67, 21);
            this.rollButton.TabIndex = 13;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // p2TotalLabel
            // 
            this.p2TotalLabel.AutoSize = true;
            this.p2TotalLabel.Location = new System.Drawing.Point(157, 66);
            this.p2TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p2TotalLabel.Name = "p2TotalLabel";
            this.p2TotalLabel.Size = new System.Drawing.Size(72, 13);
            this.p2TotalLabel.TabIndex = 12;
            this.p2TotalLabel.Text = "Player 2 Total";
            // 
            // p1TotalLabel
            // 
            this.p1TotalLabel.AutoSize = true;
            this.p1TotalLabel.Location = new System.Drawing.Point(157, 44);
            this.p1TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p1TotalLabel.Name = "p1TotalLabel";
            this.p1TotalLabel.Size = new System.Drawing.Size(72, 13);
            this.p1TotalLabel.TabIndex = 11;
            this.p1TotalLabel.Text = "Player 1 Total";
            // 
            // rollHoldLabel
            // 
            this.rollHoldLabel.AutoSize = true;
            this.rollHoldLabel.Location = new System.Drawing.Point(17, 66);
            this.rollHoldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rollHoldLabel.Name = "rollHoldLabel";
            this.rollHoldLabel.Size = new System.Drawing.Size(44, 13);
            this.rollHoldLabel.TabIndex = 10;
            this.rollHoldLabel.Text = "Roll Die";
            // 
            // whoseTurnLabel
            // 
            this.whoseTurnLabel.AutoSize = true;
            this.whoseTurnLabel.Location = new System.Drawing.Point(17, 53);
            this.whoseTurnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.whoseTurnLabel.Name = "whoseTurnLabel";
            this.whoseTurnLabel.Size = new System.Drawing.Size(45, 13);
            this.whoseTurnLabel.TabIndex = 9;
            this.whoseTurnLabel.Text = "Player ?";
            this.whoseTurnLabel.Click += new System.EventHandler(this.whoseTurnLabel_Click);
            // 
            // diePicture
            // 
            this.diePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diePicture.Location = new System.Drawing.Point(83, 44);
            this.diePicture.Margin = new System.Windows.Forms.Padding(2);
            this.diePicture.Name = "diePicture";
            this.diePicture.Size = new System.Drawing.Size(37, 36);
            this.diePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diePicture.TabIndex = 8;
            this.diePicture.TabStop = false;
            this.diePicture.Click += new System.EventHandler(this.diePicture_Click);
            // 
            // p1TotalBox
            // 
            this.p1TotalBox.Location = new System.Drawing.Point(231, 40);
            this.p1TotalBox.Margin = new System.Windows.Forms.Padding(2);
            this.p1TotalBox.Name = "p1TotalBox";
            this.p1TotalBox.ReadOnly = true;
            this.p1TotalBox.Size = new System.Drawing.Size(68, 20);
            this.p1TotalBox.TabIndex = 16;
            this.p1TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // p2TotalBox
            // 
            this.p2TotalBox.Location = new System.Drawing.Point(231, 62);
            this.p2TotalBox.Margin = new System.Windows.Forms.Padding(2);
            this.p2TotalBox.Name = "p2TotalBox";
            this.p2TotalBox.ReadOnly = true;
            this.p2TotalBox.Size = new System.Drawing.Size(68, 20);
            this.p2TotalBox.TabIndex = 17;
            this.p2TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.p2TotalBox.TextChanged += new System.EventHandler(this.p2TotalBox_TextChanged);
            // 
            // PigGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 198);
            this.Controls.Add(this.p2TotalBox);
            this.Controls.Add(this.p1TotalBox);
            this.Controls.Add(this.anotherGroup);
            this.Controls.Add(this.holdButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.p2TotalLabel);
            this.Controls.Add(this.p1TotalLabel);
            this.Controls.Add(this.rollHoldLabel);
            this.Controls.Add(this.whoseTurnLabel);
            this.Controls.Add(this.diePicture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PigGameForm";
            this.Text = "Pig Game";
            this.anotherGroup.ResumeLayout(false);
            this.anotherGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox anotherGroup;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.Button holdButton;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label p2TotalLabel;
        private System.Windows.Forms.Label p1TotalLabel;
        private System.Windows.Forms.Label rollHoldLabel;
        private System.Windows.Forms.Label whoseTurnLabel;
        private System.Windows.Forms.PictureBox diePicture;
        private System.Windows.Forms.TextBox p1TotalBox;
        private System.Windows.Forms.TextBox p2TotalBox;
    }
}