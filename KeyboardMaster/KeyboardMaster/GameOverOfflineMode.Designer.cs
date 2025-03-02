namespace KeyboardMaster
{
    partial class GameOverOfflineMode
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
            this._scoreLabel = new System.Windows.Forms.Label();
            this.scoreValueLabel = new System.Windows.Forms.Label();
            this.dataBaseConnectionStatusLabel = new System.Windows.Forms.Label();
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _scoreLabel
            // 
            this._scoreLabel.AutoSize = true;
            this._scoreLabel.Location = new System.Drawing.Point(103, 71);
            this._scoreLabel.Name = "_scoreLabel";
            this._scoreLabel.Size = new System.Drawing.Size(35, 13);
            this._scoreLabel.TabIndex = 2;
            this._scoreLabel.Text = "Score";
            // 
            // scoreValueLabel
            // 
            this.scoreValueLabel.AutoSize = true;
            this.scoreValueLabel.Location = new System.Drawing.Point(144, 71);
            this.scoreValueLabel.Name = "scoreValueLabel";
            this.scoreValueLabel.Size = new System.Drawing.Size(19, 13);
            this.scoreValueLabel.TabIndex = 3;
            this.scoreValueLabel.Text = "50";
            // 
            // dataBaseConnectionStatusLabel
            // 
            this.dataBaseConnectionStatusLabel.AutoSize = true;
            this.dataBaseConnectionStatusLabel.Location = new System.Drawing.Point(58, 30);
            this.dataBaseConnectionStatusLabel.Name = "dataBaseConnectionStatusLabel";
            this.dataBaseConnectionStatusLabel.Size = new System.Drawing.Size(148, 13);
            this.dataBaseConnectionStatusLabel.TabIndex = 9;
            this.dataBaseConnectionStatusLabel.Text = "No connection to a data base";
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(193, 105);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(85, 23);
            this.backToMainMenu.TabIndex = 10;
            this.backToMainMenu.Text = "Back to menu";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // GameOverOfflineMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 140);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.dataBaseConnectionStatusLabel);
            this.Controls.Add(this.scoreValueLabel);
            this.Controls.Add(this._scoreLabel);
            this.Name = "GameOverOfflineMode";
            this.Text = "Game over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _scoreLabel;
        private System.Windows.Forms.Label scoreValueLabel;
        private System.Windows.Forms.Label dataBaseConnectionStatusLabel;
        private System.Windows.Forms.Button backToMainMenu;
    }
}