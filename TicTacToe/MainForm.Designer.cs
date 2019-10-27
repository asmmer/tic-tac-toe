namespace TicTacToe
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SidePanel = new System.Windows.Forms.Panel();
            this.StopButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AboutProgramButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.OScoreLabel = new System.Windows.Forms.Label();
            this.OLabel = new System.Windows.Forms.Label();
            this.XScoreLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.TurnPanel = new System.Windows.Forms.Panel();
            this.TurnValue = new System.Windows.Forms.Label();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.TipLabel = new System.Windows.Forms.Label();
            this.GameNameTitle = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.ScorePanel.SuspendLayout();
            this.TurnPanel.SuspendLayout();
            this.GridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.SidePanel.Controls.Add(this.StopButton);
            this.SidePanel.Controls.Add(this.RestartButton);
            this.SidePanel.Controls.Add(this.StartButton);
            this.SidePanel.Controls.Add(this.SettingsButton);
            this.SidePanel.Controls.Add(this.AboutProgramButton);
            this.SidePanel.Controls.Add(this.GameNameTitle);
            this.SidePanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(200, 561);
            this.SidePanel.TabIndex = 1;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Enabled = false;
            this.StopButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(12, 387);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(175, 50);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestartButton.Enabled = false;
            this.RestartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.RestartButton.FlatAppearance.BorderSize = 0;
            this.RestartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartButton.Location = new System.Drawing.Point(12, 143);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(175, 50);
            this.RestartButton.TabIndex = 1;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(12, 87);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(175, 50);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Play";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.Location = new System.Drawing.Point(12, 443);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(175, 50);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AboutProgramButton
            // 
            this.AboutProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutProgramButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutProgramButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.AboutProgramButton.FlatAppearance.BorderSize = 0;
            this.AboutProgramButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.AboutProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutProgramButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutProgramButton.Location = new System.Drawing.Point(12, 499);
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(175, 50);
            this.AboutProgramButton.TabIndex = 1;
            this.AboutProgramButton.Text = "?";
            this.AboutProgramButton.UseVisualStyleBackColor = true;
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.TopPanel.Controls.Add(this.ScorePanel);
            this.TopPanel.Controls.Add(this.TurnPanel);
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Enabled = false;
            this.TopPanel.Location = new System.Drawing.Point(200, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(584, 75);
            this.TopPanel.TabIndex = 2;
            // 
            // ScorePanel
            // 
            this.ScorePanel.Controls.Add(this.OScoreLabel);
            this.ScorePanel.Controls.Add(this.OLabel);
            this.ScorePanel.Controls.Add(this.XScoreLabel);
            this.ScorePanel.Controls.Add(this.XLabel);
            this.ScorePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScorePanel.Location = new System.Drawing.Point(284, 0);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(300, 75);
            this.ScorePanel.TabIndex = 3;
            // 
            // OScoreLabel
            // 
            this.OScoreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OScoreLabel.Location = new System.Drawing.Point(225, 0);
            this.OScoreLabel.Name = "OScoreLabel";
            this.OScoreLabel.Size = new System.Drawing.Size(75, 75);
            this.OScoreLabel.TabIndex = 2;
            this.OScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OLabel
            // 
            this.OLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.OLabel.Location = new System.Drawing.Point(150, 0);
            this.OLabel.Name = "OLabel";
            this.OLabel.Size = new System.Drawing.Size(75, 75);
            this.OLabel.TabIndex = 2;
            this.OLabel.Text = "O";
            this.OLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XScoreLabel
            // 
            this.XScoreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XScoreLabel.Location = new System.Drawing.Point(75, 0);
            this.XScoreLabel.Name = "XScoreLabel";
            this.XScoreLabel.Size = new System.Drawing.Size(75, 75);
            this.XScoreLabel.TabIndex = 2;
            this.XScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // XLabel
            // 
            this.XLabel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.XLabel.Location = new System.Drawing.Point(0, 0);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(75, 75);
            this.XLabel.TabIndex = 2;
            this.XLabel.Text = "X";
            this.XLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TurnPanel
            // 
            this.TurnPanel.Controls.Add(this.TurnValue);
            this.TurnPanel.Controls.Add(this.TurnLabel);
            this.TurnPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TurnPanel.Location = new System.Drawing.Point(0, 0);
            this.TurnPanel.Name = "TurnPanel";
            this.TurnPanel.Size = new System.Drawing.Size(200, 75);
            this.TurnPanel.TabIndex = 2;
            this.TurnPanel.Visible = false;
            // 
            // TurnValue
            // 
            this.TurnValue.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnValue.Location = new System.Drawing.Point(125, 0);
            this.TurnValue.Name = "TurnValue";
            this.TurnValue.Size = new System.Drawing.Size(75, 75);
            this.TurnValue.TabIndex = 1;
            this.TurnValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TurnLabel
            // 
            this.TurnLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnLabel.Location = new System.Drawing.Point(0, 0);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(125, 75);
            this.TurnLabel.TabIndex = 1;
            this.TurnLabel.Text = "Turn:";
            this.TurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GridPanel
            // 
            this.GridPanel.Controls.Add(this.TipLabel);
            this.GridPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.Location = new System.Drawing.Point(200, 75);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(584, 486);
            this.GridPanel.TabIndex = 3;
            // 
            // TipLabel
            // 
            this.TipLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipLabel.Location = new System.Drawing.Point(0, 0);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(584, 486);
            this.TipLabel.TabIndex = 0;
            this.TipLabel.Text = "Press \"Play\" to start";
            this.TipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameNameTitle
            // 
            this.GameNameTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameNameTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameNameTitle.Location = new System.Drawing.Point(0, 0);
            this.GameNameTitle.Name = "GameNameTitle";
            this.GameNameTitle.Size = new System.Drawing.Size(200, 75);
            this.GameNameTitle.TabIndex = 0;
            this.GameNameTitle.Text = "TicTacToe";
            this.GameNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SidePanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.ScorePanel.ResumeLayout(false);
            this.TurnPanel.ResumeLayout(false);
            this.GridPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button AboutProgramButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel TurnPanel;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Label TurnValue;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.Label OScoreLabel;
        private System.Windows.Forms.Label OLabel;
        private System.Windows.Forms.Label XScoreLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label GameNameTitle;
    }
}

