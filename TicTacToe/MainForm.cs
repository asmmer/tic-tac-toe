using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private readonly SettingsForm settingsForm;
        private readonly AboutProgramForm aboutProgramForm;
        private readonly Game game;

        public MainForm()
        {
            InitializeComponent();
            SetTheme();

            game = new Game(this);

            UpdateScore();

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
            SetGrid();
            ResizeGrid();
            SetTopPanelEnabled(true);

            TurnPanel.Visible = (Settings.gameMode == GameMode.PlayerVSPlayer) ? true : false;

            StartButton.Enabled = false;
            SettingsButton.Enabled = false;
            TipLabel.Hide();

            RestartButton.Enabled = true;
            StopButton.Enabled = true;
        }

        public void UpdateScore()
        {
            XScoreLabel.Text = $"{game.xScore}";
            OScoreLabel.Text = $"{game.oScore}";
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
            game.ClearScore();
            game.ToggleEnabledGrid(false);

            StartButton.Enabled = true;
            SettingsButton.Enabled = true;
            TipLabel.Show();

            RestartButton.Enabled = false;
            StopButton.Enabled = false;

            UpdateScore();
        }

        private void SetTopPanelEnabled(bool enabled)
        {
            TopPanel.Enabled = enabled;
        }

        public void SetTurnValue(Sign order)
        {
            TurnValue.Text = $"{order}";
        }

        private void SetGrid()
        {
            List<List<Button>> grid = game.GetGrid();

            if (GridPanel.Controls.OfType<Button>().ToList().Count == 0 &&
                GridPanel.Controls.OfType<Button>().ToList().Count / Settings.gridSize != Settings.gridSize)
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

        private void ResizeGrid()
        {
            List<List<Button>> grid = game.GetGrid();

            for (byte rows = 0; rows < Settings.gridSize; rows++)
            {
                for (byte columns = 0; columns < Settings.gridSize; columns++)
                {
                    Button cellButton = grid[rows][columns];

                    // Size calculating.
                    short x = Convert.ToInt16(this.GridPanel.Width * columns / Settings.gridSize);
                    short y = Convert.ToInt16(this.GridPanel.Height * rows / Settings.gridSize);
                    short width = Convert.ToInt16(this.GridPanel.Width / Settings.gridSize);
                    short height = Convert.ToInt16(this.GridPanel.Height / Settings.gridSize);
                    short fontSize = Convert.ToInt16(width / 3);

                    // Resizing.
                    cellButton.Location = new Point(x, y);
                    cellButton.Size = new Size(width, height);
                    cellButton.Font = new Font(cellButton.Font.Name, fontSize, FontStyle.Bold);
                }
            }
        }

        public void DeleteGrid()
        {
            if (GridPanel.Controls.OfType<Button>().ToList().Count > 0 &&
                GridPanel.Controls.OfType<Button>().ToList().Count / Settings.gridSize != Settings.gridSize)
            {
                GridPanel.Controls.OfType<Button>().ToList().ForEach(cell => cell.Dispose());
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
        private void GridPanel_Resize(object sender, EventArgs e)
        {
            ResizeGrid();
        }

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
