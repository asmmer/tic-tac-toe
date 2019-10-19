using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        // Methods.
        private void SaveSettings()
        {
            byte gridSize = Convert.ToByte(SetGridSizeNUD.Value);
            GameMode gameMode = (PVPRadioButton.Checked) ? GameMode.PlayerVSPlayer : GameMode.PlayerVSBot;
            Theme theme = (LightThemeRadioButton.Checked) ? Theme.Light : Theme.Dark;

            Settings.Set(gridSize, gameMode, theme);
        }

        // Handlers.
        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Hide();
        }
    }
}
