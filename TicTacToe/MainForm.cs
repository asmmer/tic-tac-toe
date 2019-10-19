using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        SettingsForm settingsForm = new SettingsForm();
        AboutProgramForm aboutProgramForm = new AboutProgramForm();

        Game game;

        public MainForm()
        {
            InitializeComponent();

            game = new Game();
        }

        // Methods.
        private void StartGame()
        {
            ClearGrid();

            game.Start();

            SetTurnValue(game.order);
            SetGrid(game.GetGrid());
            SetTopPanelEnabled(true);
        }

        private void SetTopPanelEnabled(bool enabled)
        {
            TopPanel.Enabled = enabled;
        }

        private void SetTurnValue(Sign order)
        {
            TurnValue.Text = $"{order}";
        }

        private void SetGrid(List<Button> grid)
        {
            if (GridPanel.Controls.Count == 0 && 
                GridPanel.Controls.Count / Settings.gridSize != Settings.gridSize)
            {
                foreach (Button cell in grid)
                {
                    GridPanel.Controls.Add(cell);
                }
            }
        }

        private void ClearGrid()
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
    }
}
