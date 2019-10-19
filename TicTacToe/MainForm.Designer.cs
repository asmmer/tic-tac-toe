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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GridPanel = new System.Windows.Forms.Panel();
            this.GridSizeLabel = new System.Windows.Forms.Label();
            this.GridSizePanel = new System.Windows.Forms.Panel();
            this.SetGridSizeNUD = new System.Windows.Forms.NumericUpDown();
            this.SidePanel.SuspendLayout();
            this.GridSizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetGridSizeNUD)).BeginInit();
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
            this.SidePanel.Controls.Add(this.GridSizePanel);
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
            this.AboutProgramButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutProgramButton.Location = new System.Drawing.Point(12, 499);
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(175, 50);
            this.AboutProgramButton.TabIndex = 1;
            this.AboutProgramButton.Text = "?";
            this.AboutProgramButton.UseVisualStyleBackColor = true;
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 50);
            this.panel1.TabIndex = 2;
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
            // GridSizeLabel
            // 
            this.GridSizeLabel.AutoSize = true;
            this.GridSizeLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GridSizeLabel.Location = new System.Drawing.Point(5, 13);
            this.GridSizeLabel.Name = "GridSizeLabel";
            this.GridSizeLabel.Size = new System.Drawing.Size(70, 21);
            this.GridSizeLabel.TabIndex = 2;
            this.GridSizeLabel.Text = "Grid size";
            // 
            // GridSizePanel
            // 
            this.GridSizePanel.Controls.Add(this.SetGridSizeNUD);
            this.GridSizePanel.Controls.Add(this.GridSizeLabel);
            this.GridSizePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridSizePanel.Location = new System.Drawing.Point(0, 50);
            this.GridSizePanel.Name = "GridSizePanel";
            this.GridSizePanel.Size = new System.Drawing.Size(200, 50);
            this.GridSizePanel.TabIndex = 4;
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
            this.SetGridSizeNUD.ValueChanged += new System.EventHandler(this.SetGridSizeNUD_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SidePanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.SidePanel.ResumeLayout(false);
            this.GridSizePanel.ResumeLayout(false);
            this.GridSizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetGridSizeNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GameNameTitle;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button AboutProgramButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel GridPanel;
        private System.Windows.Forms.Panel GridSizePanel;
        private System.Windows.Forms.Label GridSizeLabel;
        private System.Windows.Forms.NumericUpDown SetGridSizeNUD;
    }
}

