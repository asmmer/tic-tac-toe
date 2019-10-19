namespace TicTacToe
{
    partial class SettingsForm
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
            this.SettingsTitle = new System.Windows.Forms.Label();
            this.GridSizePanel = new System.Windows.Forms.Panel();
            this.SetGridSizeNUD = new System.Windows.Forms.NumericUpDown();
            this.GridSizeLabel = new System.Windows.Forms.Label();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.GameModePanel = new System.Windows.Forms.Panel();
            this.PVBRadioButton = new System.Windows.Forms.RadioButton();
            this.PVPRadioButton = new System.Windows.Forms.RadioButton();
            this.GameModeLabel = new System.Windows.Forms.Label();
            this.ThemePanel = new System.Windows.Forms.Panel();
            this.DarkThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.LightThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridSizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetGridSizeNUD)).BeginInit();
            this.GameModePanel.SuspendLayout();
            this.ThemePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTitle
            // 
            this.SettingsTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.SettingsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsTitle.Location = new System.Drawing.Point(0, 0);
            this.SettingsTitle.Name = "SettingsTitle";
            this.SettingsTitle.Size = new System.Drawing.Size(784, 75);
            this.SettingsTitle.TabIndex = 1;
            this.SettingsTitle.Text = "Settings";
            this.SettingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridSizePanel
            // 
            this.GridSizePanel.Controls.Add(this.SetGridSizeNUD);
            this.GridSizePanel.Controls.Add(this.GridSizeLabel);
            this.GridSizePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridSizePanel.Location = new System.Drawing.Point(0, 75);
            this.GridSizePanel.Name = "GridSizePanel";
            this.GridSizePanel.Size = new System.Drawing.Size(784, 50);
            this.GridSizePanel.TabIndex = 5;
            // 
            // SetGridSizeNUD
            // 
            this.SetGridSizeNUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SetGridSizeNUD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SetGridSizeNUD.Location = new System.Drawing.Point(140, 13);
            this.SetGridSizeNUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.SetGridSizeNUD.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SetGridSizeNUD.Name = "SetGridSizeNUD";
            this.SetGridSizeNUD.ReadOnly = true;
            this.SetGridSizeNUD.Size = new System.Drawing.Size(54, 25);
            this.SetGridSizeNUD.TabIndex = 5;
            this.SetGridSizeNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SetGridSizeNUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // GridSizeLabel
            // 
            this.GridSizeLabel.AutoSize = true;
            this.GridSizeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GridSizeLabel.Location = new System.Drawing.Point(15, 13);
            this.GridSizeLabel.Name = "GridSizeLabel";
            this.GridSizeLabel.Size = new System.Drawing.Size(72, 21);
            this.GridSizeLabel.TabIndex = 2;
            this.GridSizeLabel.Text = "Grid size";
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.SaveSettingsButton.FlatAppearance.BorderSize = 0;
            this.SaveSettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.SaveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSettingsButton.Location = new System.Drawing.Point(12, 13);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(760, 50);
            this.SaveSettingsButton.TabIndex = 6;
            this.SaveSettingsButton.Text = "Save";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // GameModePanel
            // 
            this.GameModePanel.Controls.Add(this.PVBRadioButton);
            this.GameModePanel.Controls.Add(this.PVPRadioButton);
            this.GameModePanel.Controls.Add(this.GameModeLabel);
            this.GameModePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameModePanel.Location = new System.Drawing.Point(0, 125);
            this.GameModePanel.Name = "GameModePanel";
            this.GameModePanel.Size = new System.Drawing.Size(784, 50);
            this.GameModePanel.TabIndex = 7;
            // 
            // PVBRadioButton
            // 
            this.PVBRadioButton.AutoSize = true;
            this.PVBRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PVBRadioButton.Location = new System.Drawing.Point(287, 11);
            this.PVBRadioButton.Name = "PVBRadioButton";
            this.PVBRadioButton.Size = new System.Drawing.Size(121, 25);
            this.PVBRadioButton.TabIndex = 3;
            this.PVBRadioButton.TabStop = true;
            this.PVBRadioButton.Tag = "PlayerVSBot";
            this.PVBRadioButton.Text = "Player VS Bot";
            this.PVBRadioButton.UseVisualStyleBackColor = true;
            // 
            // PVPRadioButton
            // 
            this.PVPRadioButton.AutoSize = true;
            this.PVPRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PVPRadioButton.Location = new System.Drawing.Point(140, 11);
            this.PVPRadioButton.Name = "PVPRadioButton";
            this.PVPRadioButton.Size = new System.Drawing.Size(141, 25);
            this.PVPRadioButton.TabIndex = 3;
            this.PVPRadioButton.TabStop = true;
            this.PVPRadioButton.Tag = "PlayerVSPlayer";
            this.PVPRadioButton.Text = "Player VS Player";
            this.PVPRadioButton.UseVisualStyleBackColor = true;
            // 
            // GameModeLabel
            // 
            this.GameModeLabel.AutoSize = true;
            this.GameModeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameModeLabel.Location = new System.Drawing.Point(15, 13);
            this.GameModeLabel.Name = "GameModeLabel";
            this.GameModeLabel.Size = new System.Drawing.Size(100, 21);
            this.GameModeLabel.TabIndex = 2;
            this.GameModeLabel.Text = "Game Mode";
            // 
            // ThemePanel
            // 
            this.ThemePanel.Controls.Add(this.DarkThemeRadioButton);
            this.ThemePanel.Controls.Add(this.LightThemeRadioButton);
            this.ThemePanel.Controls.Add(this.ThemeLabel);
            this.ThemePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThemePanel.Location = new System.Drawing.Point(0, 175);
            this.ThemePanel.Name = "ThemePanel";
            this.ThemePanel.Size = new System.Drawing.Size(784, 50);
            this.ThemePanel.TabIndex = 8;
            // 
            // DarkThemeRadioButton
            // 
            this.DarkThemeRadioButton.AutoSize = true;
            this.DarkThemeRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DarkThemeRadioButton.Location = new System.Drawing.Point(287, 11);
            this.DarkThemeRadioButton.Name = "DarkThemeRadioButton";
            this.DarkThemeRadioButton.Size = new System.Drawing.Size(61, 25);
            this.DarkThemeRadioButton.TabIndex = 3;
            this.DarkThemeRadioButton.TabStop = true;
            this.DarkThemeRadioButton.Tag = "Dark";
            this.DarkThemeRadioButton.Text = "Dark";
            this.DarkThemeRadioButton.UseVisualStyleBackColor = true;
            // 
            // LightThemeRadioButton
            // 
            this.LightThemeRadioButton.AutoSize = true;
            this.LightThemeRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LightThemeRadioButton.Location = new System.Drawing.Point(140, 11);
            this.LightThemeRadioButton.Name = "LightThemeRadioButton";
            this.LightThemeRadioButton.Size = new System.Drawing.Size(63, 25);
            this.LightThemeRadioButton.TabIndex = 3;
            this.LightThemeRadioButton.TabStop = true;
            this.LightThemeRadioButton.Tag = "Light";
            this.LightThemeRadioButton.Text = "Light";
            this.LightThemeRadioButton.UseVisualStyleBackColor = true;
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeLabel.Location = new System.Drawing.Point(15, 13);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(60, 21);
            this.ThemeLabel.TabIndex = 2;
            this.ThemeLabel.Text = "Theme";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveSettingsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 75);
            this.panel1.TabIndex = 9;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ThemePanel);
            this.Controls.Add(this.GameModePanel);
            this.Controls.Add(this.GridSizePanel);
            this.Controls.Add(this.SettingsTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.GridSizePanel.ResumeLayout(false);
            this.GridSizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetGridSizeNUD)).EndInit();
            this.GameModePanel.ResumeLayout(false);
            this.GameModePanel.PerformLayout();
            this.ThemePanel.ResumeLayout(false);
            this.ThemePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SettingsTitle;
        private System.Windows.Forms.Panel GridSizePanel;
        private System.Windows.Forms.NumericUpDown SetGridSizeNUD;
        private System.Windows.Forms.Label GridSizeLabel;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Panel GameModePanel;
        private System.Windows.Forms.Label GameModeLabel;
        private System.Windows.Forms.RadioButton PVBRadioButton;
        private System.Windows.Forms.RadioButton PVPRadioButton;
        private System.Windows.Forms.Panel ThemePanel;
        private System.Windows.Forms.RadioButton DarkThemeRadioButton;
        private System.Windows.Forms.RadioButton LightThemeRadioButton;
        private System.Windows.Forms.Label ThemeLabel;
        private System.Windows.Forms.Panel panel1;
    }
}