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
            this.GameNameTitle = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.AboutProgramButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameNameTitle
            // 
            this.GameNameTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameNameTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameNameTitle.Location = new System.Drawing.Point(0, 0);
            this.GameNameTitle.Name = "GameNameTitle";
            this.GameNameTitle.Size = new System.Drawing.Size(200, 50);
            this.GameNameTitle.TabIndex = 0;
            this.GameNameTitle.Text = "TicTacToe";
            this.GameNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.SidePanel.Controls.Add(this.PlayButton);
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
            // AboutProgramButton
            // 
            this.AboutProgramButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutProgramButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutProgramButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.AboutProgramButton.FlatAppearance.BorderSize = 0;
            this.AboutProgramButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.AboutProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutProgramButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(200, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(584, 50);
            this.TopPanel.TabIndex = 2;
            // 
            // GridPanel
            // 
            this.GridPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPanel.Location = new System.Drawing.Point(200, 50);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(584, 511);
            this.GridPanel.TabIndex = 3;
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
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.Location = new System.Drawing.Point(12, 443);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(175, 50);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(12, 62);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(175, 50);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GameNameTitle;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button AboutProgramButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button PlayButton;
    }
}

