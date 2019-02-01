namespace card_games
{
    partial class pigWithTwoDice
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
            this.p1TotalLabel = new System.Windows.Forms.Label();
            this.p2TotalLabel = new System.Windows.Forms.Label();
            this.whoseTurnLabel = new System.Windows.Forms.Label();
            this.rollHoldLabel = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.holdButton = new System.Windows.Forms.Button();
            this.p1TotalBox = new System.Windows.Forms.TextBox();
            this.p2TotalBox = new System.Windows.Forms.TextBox();
            this.anotherGroup = new System.Windows.Forms.GroupBox();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.diePicture2 = new System.Windows.Forms.PictureBox();
            this.diePicture1 = new System.Windows.Forms.PictureBox();
            this.anotherGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diePicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // p1TotalLabel
            // 
            this.p1TotalLabel.AutoSize = true;
            this.p1TotalLabel.Location = new System.Drawing.Point(327, 101);
            this.p1TotalLabel.Name = "p1TotalLabel";
            this.p1TotalLabel.Size = new System.Drawing.Size(104, 20);
            this.p1TotalLabel.TabIndex = 12;
            this.p1TotalLabel.Text = "Player 1 Total";
            // 
            // p2TotalLabel
            // 
            this.p2TotalLabel.AutoSize = true;
            this.p2TotalLabel.Location = new System.Drawing.Point(327, 139);
            this.p2TotalLabel.Name = "p2TotalLabel";
            this.p2TotalLabel.Size = new System.Drawing.Size(104, 20);
            this.p2TotalLabel.TabIndex = 13;
            this.p2TotalLabel.Text = "Player 2 Total";
            // 
            // whoseTurnLabel
            // 
            this.whoseTurnLabel.AutoSize = true;
            this.whoseTurnLabel.Location = new System.Drawing.Point(17, 101);
            this.whoseTurnLabel.Name = "whoseTurnLabel";
            this.whoseTurnLabel.Size = new System.Drawing.Size(65, 20);
            this.whoseTurnLabel.TabIndex = 14;
            this.whoseTurnLabel.Text = "Player ?";
            // 
            // rollHoldLabel
            // 
            this.rollHoldLabel.AutoSize = true;
            this.rollHoldLabel.Location = new System.Drawing.Point(17, 139);
            this.rollHoldLabel.Name = "rollHoldLabel";
            this.rollHoldLabel.Size = new System.Drawing.Size(64, 20);
            this.rollHoldLabel.TabIndex = 15;
            this.rollHoldLabel.Text = "Roll Die";
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.Lime;
            this.rollButton.Location = new System.Drawing.Point(100, 248);
            this.rollButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(100, 32);
            this.rollButton.TabIndex = 16;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // holdButton
            // 
            this.holdButton.BackColor = System.Drawing.Color.Red;
            this.holdButton.Enabled = false;
            this.holdButton.Location = new System.Drawing.Point(243, 248);
            this.holdButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(100, 32);
            this.holdButton.TabIndex = 17;
            this.holdButton.Text = "Hold";
            this.holdButton.UseVisualStyleBackColor = false;
            this.holdButton.Click += new System.EventHandler(this.holdButton_Click_1);
            // 
            // p1TotalBox
            // 
            this.p1TotalBox.Location = new System.Drawing.Point(454, 98);
            this.p1TotalBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p1TotalBox.Name = "p1TotalBox";
            this.p1TotalBox.ReadOnly = true;
            this.p1TotalBox.Size = new System.Drawing.Size(100, 26);
            this.p1TotalBox.TabIndex = 18;
            this.p1TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.p1TotalBox.TextChanged += new System.EventHandler(this.p1TotalBox_TextChanged);
            // 
            // p2TotalBox
            // 
            this.p2TotalBox.Location = new System.Drawing.Point(454, 139);
            this.p2TotalBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.p2TotalBox.Name = "p2TotalBox";
            this.p2TotalBox.ReadOnly = true;
            this.p2TotalBox.Size = new System.Drawing.Size(100, 26);
            this.p2TotalBox.TabIndex = 19;
            this.p2TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // anotherGroup
            // 
            this.anotherGroup.Controls.Add(this.noRadio);
            this.anotherGroup.Controls.Add(this.yesRadio);
            this.anotherGroup.Enabled = false;
            this.anotherGroup.Location = new System.Drawing.Point(432, 211);
            this.anotherGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anotherGroup.Name = "anotherGroup";
            this.anotherGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anotherGroup.Size = new System.Drawing.Size(143, 139);
            this.anotherGroup.TabIndex = 20;
            this.anotherGroup.TabStop = false;
            this.anotherGroup.Text = "Another Game?";
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Location = new System.Drawing.Point(32, 80);
            this.noRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(54, 24);
            this.noRadio.TabIndex = 1;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            this.noRadio.CheckedChanged += new System.EventHandler(this.noRadio_CheckedChanged_1);
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Location = new System.Drawing.Point(32, 42);
            this.yesRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(62, 24);
            this.yesRadio.TabIndex = 0;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // diePicture2
            // 
            this.diePicture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diePicture2.Location = new System.Drawing.Point(228, 101);
            this.diePicture2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diePicture2.Name = "diePicture2";
            this.diePicture2.Size = new System.Drawing.Size(55, 54);
            this.diePicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diePicture2.TabIndex = 21;
            this.diePicture2.TabStop = false;
            // 
            // diePicture1
            // 
            this.diePicture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diePicture1.Location = new System.Drawing.Point(145, 101);
            this.diePicture1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diePicture1.Name = "diePicture1";
            this.diePicture1.Size = new System.Drawing.Size(55, 54);
            this.diePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diePicture1.TabIndex = 22;
            this.diePicture1.TabStop = false;
            this.diePicture1.Click += new System.EventHandler(this.diePicture1_Click);
            // 
            // pigWithTwoDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 366);
            this.Controls.Add(this.diePicture1);
            this.Controls.Add(this.diePicture2);
            this.Controls.Add(this.anotherGroup);
            this.Controls.Add(this.p2TotalBox);
            this.Controls.Add(this.p1TotalBox);
            this.Controls.Add(this.holdButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.rollHoldLabel);
            this.Controls.Add(this.whoseTurnLabel);
            this.Controls.Add(this.p2TotalLabel);
            this.Controls.Add(this.p1TotalLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "pigWithTwoDice";
            this.Text = "pigWithTwoDice";
            this.anotherGroup.ResumeLayout(false);
            this.anotherGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diePicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label p1TotalLabel;
        private System.Windows.Forms.Label p2TotalLabel;
        private System.Windows.Forms.Label whoseTurnLabel;
        private System.Windows.Forms.Label rollHoldLabel;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button holdButton;
        private System.Windows.Forms.TextBox p1TotalBox;
        private System.Windows.Forms.TextBox p2TotalBox;
        private System.Windows.Forms.GroupBox anotherGroup;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.PictureBox diePicture2;
        private System.Windows.Forms.PictureBox diePicture1;
    }
}