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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _scoreeLabel
            // 
            this._scoreeLabel.AutoSize = true;
            this._scoreeLabel.Location = new System.Drawing.Point(94, 65);
            this._scoreeLabel.Name = "_scoreeLabel";
            this._scoreeLabel.Size = new System.Drawing.Size(35, 13);
            this._scoreeLabel.TabIndex = 0;
            this._scoreeLabel.Text = "Score";
            // 
            // _scoreValueLabel
            // 
            this._scoreValueLabel.AutoSize = true;
            this._scoreValueLabel.Location = new System.Drawing.Point(135, 65);
            this._scoreValueLabel.Name = "_scoreValueLabel";
            this._scoreValueLabel.Size = new System.Drawing.Size(19, 13);
            this._scoreValueLabel.TabIndex = 1;
            this._scoreValueLabel.Text = "50";
            // 
            // _nickNameLabel
            // 
            this._nickNameLabel.AutoSize = true;
            this._nickNameLabel.Location = new System.Drawing.Point(79, 125);
            this._nickNameLabel.Name = "_nickNameLabel";
            this._nickNameLabel.Size = new System.Drawing.Size(84, 13);
            this._nickNameLabel.TabIndex = 2;
            this._nickNameLabel.Text = "Enter nick name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(189, 100);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(46, 23);
            this._okButton.TabIndex = 4;
            this._okButton.Text = "ok";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 200);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._nickNameLabel);
            this.Controls.Add(this._scoreValueLabel);
            this.Controls.Add(this._scoreeLabel);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _scoreeLabel;
        private System.Windows.Forms.Label _scoreValueLabel;
        private System.Windows.Forms.Label _nickNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button _okButton;
    }
}