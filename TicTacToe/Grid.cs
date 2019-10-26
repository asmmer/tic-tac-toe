using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public class Grid
    {
        private List<List<Button>> grid = new List<List<Button>>();
        private Game game;

        public Grid(Game game)
        {
            this.game = game;
        }

        // Methods.
        public void SetGrid(byte gridSize)
        {
            if (gridSize < Constants.MIN_GRID_SIZE || gridSize > Constants.MAX_GRID_SIZE)
            {
                MessageBox.Show($"Size is equals - {gridSize}. Need to pick another.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (grid.Count > 0)
            {
                Delete();
            }

            int adjustableValue = (gridSize == 4) ? 40 :
                                  (gridSize == 5) ? 60 : 
                                  (gridSize == 6) ? 75 : 
                                  (gridSize == 7) ? 85 : 
                                  (gridSize == 8) ? 90 : 
                                  (gridSize == 9) ? 100 :
                                  (gridSize == 10) ? 105 :
                                  (gridSize == 11) ? 108 :
                                  (gridSize == 12) ? 111 : 
                                  (gridSize == 13) ? 114 :
                                  (gridSize == 14) ? 117 :
                                  (gridSize == 15) ? 120 : 0;

            for (byte rows = 0; rows < gridSize; rows++)
            {
                grid.Add(new List<Button>());
                for (byte columns = 0; columns < gridSize; columns++)
                {
                    Button cellButton = new Button();

                    cellButton.Size = new Size(Constants.CELL_SIZE - adjustableValue, Constants.CELL_SIZE - adjustableValue);
                    cellButton.Location = new Point(rows * (Constants.CELL_SIZE - adjustableValue), columns * (Constants.CELL_SIZE - adjustableValue));
                    cellButton.Cursor = Cursors.Hand;
                    cellButton.FlatStyle = FlatStyle.Flat;
                    cellButton.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
                    cellButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                    cellButton.Font = new Font(cellButton.Font.Name, (Constants.CELL_SIZE - adjustableValue) / 3, FontStyle.Bold);
                    cellButton.TabStop = false;
                    cellButton.Click += CellButton_Click;

                    grid[rows].Add(cellButton);
                }
            }
        }

        public bool IsFull()
        {
            for (byte rows = 0; rows < Settings.gridSize; rows++)
            {
                for (byte columns = 0; columns < Settings.gridSize; columns++)
                {
                    if (grid[rows][columns].Text == String.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public List<List<Button>> Value
        {
            get
            {
                return grid;
            }
        }

        public void ToggleEnabled(bool enabled)
        {
            for (byte rows = 0; rows < Settings.gridSize; rows++)
            {
                for (byte columns = 0; columns < Settings.gridSize; columns++)
                {
                    grid[rows][columns].Enabled = enabled;
                }
            }
        }

        public void Clear()
        {
            for (byte rows = 0; rows < Settings.gridSize; rows++)
            {
                for (byte columns = 0; columns < Settings.gridSize; columns++)
                {
                    grid[rows][columns].Text = String.Empty;
                }
            }
        }

        public void Delete()
        {
            grid.Clear();
        }

        private bool IsEmptyCell(string cellValue)
        {
            return (String.IsNullOrEmpty(cellValue)) ? true : false;
        }

        // Handlers.
        private void CellButton_Click(object sender, EventArgs e)
        {
            Button cell = (Button)sender;

            if (IsEmptyCell(cell.Text))
            {
                cell.Text = $"{game.order}";
                game.CellClick();
            }
        }
    }
}
