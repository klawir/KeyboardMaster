namespace KeyboardMaster
{
    partial class ScorePopup
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
            this.scoreListView = new System.Windows.Forms.ListView();
            this.playerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scoreCcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreListView
            // 
            this.scoreListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerColumnHeader,
            this.scoreCcolumnHeader});
            this.scoreListView.HideSelection = false;
            this.scoreListView.Location = new System.Drawing.Point(57, 22);
            this.scoreListView.Name = "scoreListView";
            this.scoreListView.Size = new System.Drawing.Size(126, 191);
            this.scoreListView.TabIndex = 6;
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
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(75, 219);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(85, 23);
            this.backToMainMenu.TabIndex = 7;
            this.backToMainMenu.Text = "Back to menu";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // ScorePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 281);
            this.Controls.Add(this.backToMainMenu);
            this.Controls.Add(this.scoreListView);
            this.Name = "ScorePopup";
            this.Text = "Score";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView scoreListView;
        private System.Windows.Forms.ColumnHeader playerColumnHeader;
        private System.Windows.Forms.ColumnHeader scoreCcolumnHeader;
        private System.Windows.Forms.Button backToMainMenu;
    }
}