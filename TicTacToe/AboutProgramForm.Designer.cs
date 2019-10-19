namespace TicTacToe
{
    partial class AboutProgramForm
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
            this.HowToPlayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HowToPlayLabel
            // 
            this.HowToPlayLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.HowToPlayLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HowToPlayLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HowToPlayLabel.Location = new System.Drawing.Point(0, 0);
            this.HowToPlayLabel.Name = "HowToPlayLabel";
            this.HowToPlayLabel.Size = new System.Drawing.Size(784, 75);
            this.HowToPlayLabel.TabIndex = 2;
            this.HowToPlayLabel.Text = "How to play";
            this.HowToPlayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.HowToPlayLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe - About program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HowToPlayLabel;
    }
}