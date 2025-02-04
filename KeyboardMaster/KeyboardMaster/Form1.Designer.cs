using System.Windows.Forms;

namespace KeyboardMaster
{
    partial class Form1
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

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pointsLabel = new System.Windows.Forms.Label();
            this.pointsValue = new System.Windows.Forms.Label();
            this.chancesValueLabel = new System.Windows.Forms.Label();
            this.chancesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pointsLabel.Location = new System.Drawing.Point(12, 9);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(47, 17);
            this.pointsLabel.TabIndex = 1;
            this.pointsLabel.Text = "Points";
            // 
            // pointsValue
            // 
            this.pointsValue.AutoSize = true;
            this.pointsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pointsValue.Location = new System.Drawing.Point(81, 9);
            this.pointsValue.Name = "pointsValue";
            this.pointsValue.Size = new System.Drawing.Size(16, 17);
            this.pointsValue.TabIndex = 2;
            this.pointsValue.Text = "0";
            // 
            // chancesValueLabel
            // 
            this.chancesValueLabel.AutoSize = true;
            this.chancesValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chancesValueLabel.Location = new System.Drawing.Point(81, 27);
            this.chancesValueLabel.Name = "chancesValueLabel";
            this.chancesValueLabel.Size = new System.Drawing.Size(16, 17);
            this.chancesValueLabel.TabIndex = 4;
            this.chancesValueLabel.Text = "4";
            // 
            // chancesLabel
            // 
            this.chancesLabel.AutoSize = true;
            this.chancesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chancesLabel.Location = new System.Drawing.Point(12, 26);
            this.chancesLabel.Name = "chancesLabel";
            this.chancesLabel.Size = new System.Drawing.Size(63, 17);
            this.chancesLabel.TabIndex = 3;
            this.chancesLabel.Text = "Chances";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chancesValueLabel);
            this.Controls.Add(this.chancesLabel);
            this.Controls.Add(this.pointsValue);
            this.Controls.Add(this.pointsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

