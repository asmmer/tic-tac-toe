using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class SettingsForm : Form
    {
        MainForm mainForm;
        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            SetTheme();

            this.mainForm = mainForm;

            SetGridSizeNUD.Value = Settings.gridSize;
            foreach (RadioButton GameModeRadioButton in GameModePanel.Controls.OfType<RadioButton>())
            {
                if (GameModeRadioButton.Tag.ToString() == Settings.gameMode.ToString())
                {
                    GameModeRadioButton.Checked = true;
                    break;
                }
            }
            foreach (RadioButton ThemeRadioButton in ThemePanel.Controls.OfType<RadioButton>())
            {
                if (ThemeRadioButton.Tag.ToString() == Settings.theme.ToString())
                {
                    ThemeRadioButton.Checked = true;
                    break;
                }
            }
        }

        // Methods.
        private void SetTheme()
        {
            Visualization.SetTheme(this, Settings.theme, 1);
            Visualization.SetTheme(SettingsTitle, Settings.theme, 0);
            Visualization.SetTheme(SetGridSizeNUD, Settings.theme, 0);
        }

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

            SetTheme();
            mainForm.SetTheme();

            mainForm.DeleteGrid();

            Hide();
        }
    }
}
