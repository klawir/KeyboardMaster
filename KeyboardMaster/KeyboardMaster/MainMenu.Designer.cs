namespace KeyboardMaster
{
    partial class MainMenu
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
            this._newGameButton = new System.Windows.Forms.Button();
            this._scoreButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.dataBaseConnectionStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _newGameButton
            // 
            this._newGameButton.Location = new System.Drawing.Point(83, 51);
            this._newGameButton.Name = "_newGameButton";
            this._newGameButton.Size = new System.Drawing.Size(75, 23);
            this._newGameButton.TabIndex = 0;
            this._newGameButton.Text = "New game";
            this._newGameButton.UseVisualStyleBackColor = true;
            this._newGameButton.Click += new System.EventHandler(this._newGameButton_Click);
            // 
            // _scoreButton
            // 
            this._scoreButton.Location = new System.Drawing.Point(83, 80);
            this._scoreButton.Name = "_scoreButton";
            this._scoreButton.Size = new System.Drawing.Size(75, 23);
            this._scoreButton.TabIndex = 1;
            this._scoreButton.Text = "Score";
            this._scoreButton.UseVisualStyleBackColor = true;
            this._scoreButton.Click += new System.EventHandler(this._scoreButton_Click);
            // 
            // _exitButton
            // 
            this._exitButton.Location = new System.Drawing.Point(83, 109);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(75, 23);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this._exitButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(112, 198);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(46, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectionStringTextBox.Location = new System.Drawing.Point(12, 168);
            this.connectionStringTextBox.Multiline = true;
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(237, 24);
            this.connectionStringTextBox.TabIndex = 6;
            this.connectionStringTextBox.Text = "Enter local data base name here";
            // 
            // dataBaseConnectionStatusLabel
            // 
            this.dataBaseConnectionStatusLabel.AutoSize = true;
            this.dataBaseConnectionStatusLabel.Location = new System.Drawing.Point(49, 9);
            this.dataBaseConnectionStatusLabel.Name = "dataBaseConnectionStatusLabel";
            this.dataBaseConnectionStatusLabel.Size = new System.Drawing.Size(148, 13);
            this.dataBaseConnectionStatusLabel.TabIndex = 8;
            this.dataBaseConnectionStatusLabel.Text = "No connection to a data base";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 225);
            this.Controls.Add(this.dataBaseConnectionStatusLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.connectionStringTextBox);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._scoreButton);
            this.Controls.Add(this._newGameButton);
            this.Name = "MainMenu";
            this.Text = "Main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _newGameButton;
        private System.Windows.Forms.Button _scoreButton;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox connectionStringTextBox;
        private System.Windows.Forms.Label dataBaseConnectionStatusLabel;
    }
}