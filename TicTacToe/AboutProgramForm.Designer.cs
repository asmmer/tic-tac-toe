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
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InstructionPanel = new System.Windows.Forms.Panel();
            this.FirstHeaderLabel = new System.Windows.Forms.Label();
            this.InstructionPanel.SuspendLayout();
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
            // AuthorLabel
            // 
            this.AuthorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.AuthorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.Location = new System.Drawing.Point(0, 411);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(784, 50);
            this.AuthorLabel.TabIndex = 3;
            this.AuthorLabel.Text = "Artyom Sommer - 2019";
            this.AuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(443, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "- There is the indicator on the top panel that shows whose turn it is for the mov" +
    "e\r\n- There is also the score\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "- To play, just click on Play\r\n- To clean the grid, click on Restart\r\n- To stop t" +
    "he game, click on Stop\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(42, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 105);
            this.label3.TabIndex = 4;
            this.label3.Text = "Go to the settings item by clicking Settings\r\nIn the settings you can:\r\n- adjust " +
    "the size of the grid\r\n- change the game mode (vs friend or vs computer)\r\n- chang" +
    "e the theme\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "How to change something?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(422, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Remarks:";
            // 
            // InstructionPanel
            // 
            this.InstructionPanel.Controls.Add(this.FirstHeaderLabel);
            this.InstructionPanel.Controls.Add(this.label5);
            this.InstructionPanel.Controls.Add(this.label1);
            this.InstructionPanel.Controls.Add(this.label4);
            this.InstructionPanel.Controls.Add(this.label2);
            this.InstructionPanel.Controls.Add(this.label3);
            this.InstructionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionPanel.Location = new System.Drawing.Point(0, 75);
            this.InstructionPanel.Name = "InstructionPanel";
            this.InstructionPanel.Size = new System.Drawing.Size(784, 336);
            this.InstructionPanel.TabIndex = 6;
            // 
            // FirstHeaderLabel
            // 
            this.FirstHeaderLabel.AutoSize = true;
            this.FirstHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.FirstHeaderLabel.Location = new System.Drawing.Point(27, 35);
            this.FirstHeaderLabel.Name = "FirstHeaderLabel";
            this.FirstHeaderLabel.Size = new System.Drawing.Size(149, 30);
            this.FirstHeaderLabel.TabIndex = 5;
            this.FirstHeaderLabel.Text = "How to play?";
            // 
            // AboutProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.InstructionPanel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.HowToPlayLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutProgramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About program";
            this.Load += new System.EventHandler(this.AboutProgramForm_Load);
            this.InstructionPanel.ResumeLayout(false);
            this.InstructionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HowToPlayLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel InstructionPanel;
        private System.Windows.Forms.Label FirstHeaderLabel;
    }
}