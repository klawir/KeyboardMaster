namespace KeyboardMaster
{
    partial class GameOver
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
            this._scoreeLabel = new System.Windows.Forms.Label();
            this._scoreValueLabel = new System.Windows.Forms.Label();
            this._nickNameLabel = new System.Windows.Forms.Label();
            this.nickTextBox = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this.scoreListView = new System.Windows.Forms.ListView();
            this.playerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreCcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // _scoreeLabel
            // 
            this._scoreeLabel.AutoSize = true;
            this._scoreeLabel.Location = new System.Drawing.Point(189, 265);
            this._scoreeLabel.Name = "_scoreeLabel";
            this._scoreeLabel.Size = new System.Drawing.Size(35, 13);
            this._scoreeLabel.TabIndex = 0;
            this._scoreeLabel.Text = "Score";
            // 
            // _scoreValueLabel
            // 
            this._scoreValueLabel.AutoSize = true;
            this._scoreValueLabel.Location = new System.Drawing.Point(230, 265);
            this._scoreValueLabel.Name = "_scoreValueLabel";
            this._scoreValueLabel.Size = new System.Drawing.Size(19, 13);
            this._scoreValueLabel.TabIndex = 1;
            this._scoreValueLabel.Text = "50";
            // 
            // _nickNameLabel
            // 
            this._nickNameLabel.AutoSize = true;
            this._nickNameLabel.Location = new System.Drawing.Point(174, 325);
            this._nickNameLabel.Name = "_nickNameLabel";
            this._nickNameLabel.Size = new System.Drawing.Size(84, 13);
            this._nickNameLabel.TabIndex = 2;
            this._nickNameLabel.Text = "Enter nick name";
            // 
            // nickTextBox
            // 
            this.nickTextBox.Location = new System.Drawing.Point(167, 302);
            this.nickTextBox.Name = "nickTextBox";
            this.nickTextBox.Size = new System.Drawing.Size(100, 20);
            this.nickTextBox.TabIndex = 3;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(284, 300);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(46, 23);
            this._okButton.TabIndex = 4;
            this._okButton.Text = "ok";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // scoreListView
            // 
            this.scoreListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerColumnHeader,
            this.scoreCcolumnHeader});
            this.scoreListView.HideSelection = false;
            this.scoreListView.Location = new System.Drawing.Point(155, 40);
            this.scoreListView.Name = "scoreListView";
            this.scoreListView.Size = new System.Drawing.Size(129, 139);
            this.scoreListView.TabIndex = 5;
            this.scoreListView.UseCompatibleStateImageBehavior = false;
            this.scoreListView.View = System.Windows.Forms.View.Details;
            // 
            // playerColumnHeader
            // 
            this.playerColumnHeader.Text = "Player";
            // 
            // scoreCcolumnHeader
            // 
            this.scoreCcolumnHeader.Text = "Score";
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 368);
            this.Controls.Add(this.scoreListView);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.nickTextBox);
            this.Controls.Add(this._nickNameLabel);
            this.Controls.Add(this._scoreValueLabel);
            this.Controls.Add(this._scoreeLabel);
            this.Name = "GameOver";
            this.Text = "Game over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _scoreeLabel;
        private System.Windows.Forms.Label _scoreValueLabel;
        private System.Windows.Forms.Label _nickNameLabel;
        private System.Windows.Forms.TextBox nickTextBox;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.ListView scoreListView;
        private System.Windows.Forms.ColumnHeader playerColumnHeader;
        private System.Windows.Forms.ColumnHeader scoreCcolumnHeader;
    }
}