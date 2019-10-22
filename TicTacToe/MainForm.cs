using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        readonly SettingsForm settingsForm;
        readonly AboutProgramForm aboutProgramForm;

        Game game;

        public MainForm()
        {
            InitializeComponent();
            SetTheme();

            game = new Game(this);
            settingsForm = new SettingsForm(this);
            aboutProgramForm = new AboutProgramForm();
        }

        public void SetTheme()
        {
            Visualization.SetTheme(SidePanel, Settings.theme, 0);
            Visualization.SetTheme(TopPanel, Settings.theme, 0);
            Visualization.SetTheme(GridPanel, Settings.theme, 1);
        }

        // Methods.
        private void StartGame()
        {
            DeleteGrid();

            game.Start();
            game.ToggleEnabledGrid(true);

            SetTurnValue(game.order);
            SetGrid(game.GetGrid());
            SetTopPanelEnabled(true);

            StartButton.Enabled = false;
            SettingsButton.Enabled = false;

            RestartButton.Enabled = true;
            StopButton.Enabled = true;
        }

        private void RestartGame()
        {
            game.ClearGrid();
            game.ToggleEnabledGrid(true);
        }

        public void PauseGame()
        {
            game.ToggleEnabledGrid(false);

            StartButton.Enabled = false;
            SettingsButton.Enabled = false;

            RestartButton.Enabled = true;
            StopButton.Enabled = true;
        }

        public void StopGame()
        {
            game.ClearGrid();
            game.ToggleEnabledGrid(false);

            StartButton.Enabled = true;
            SettingsButton.Enabled = true;

            RestartButton.Enabled = false;
            StopButton.Enabled = false;
        }

        private void SetTopPanelEnabled(bool enabled)
        {
            TopPanel.Enabled = enabled;
        }

        public void SetTurnValue(Sign order)
        {
            TurnValue.Text = $"{order}";
        }

        private void SetGrid(List<List<Button>> grid)
        {
            if (GridPanel.Controls.Count == 0 && 
                GridPanel.Controls.Count / Settings.gridSize != Settings.gridSize)
            {
                for (byte rows = 0; rows < Settings.gridSize; rows++)
                {
                    for (byte columns = 0; columns < Settings.gridSize; columns++)
                    {
                        GridPanel.Controls.Add(grid[rows][columns]);
                    }
                }
            }
        }

        public void DeleteGrid()
        {
            if (GridPanel.Controls.Count > 0 &&
                GridPanel.Controls.Count / Settings.gridSize != Settings.gridSize)
            {
                GridPanel.Controls.Clear();
            }
        }

        private void OpenSettingsForm()
        {
            settingsForm.ShowDialog();
        }

        private void OpenAboutProgramForm()
        {
            aboutProgramForm.ShowDialog();
        }

        // Handlers.
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            OpenSettingsForm();
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            OpenAboutProgramForm();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopGame();
        }


    }
}
