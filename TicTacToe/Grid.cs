using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public class Grid
    {
        public List<List<Button>> Value { get; } = new List<List<Button>>();
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

            if (Value.Count > 0)
            {
                Delete();
            }

            for (byte rows = 0; rows < gridSize; rows++)
            {
                Value.Add(new List<Button>());
                for (byte columns = 0; columns < gridSize; columns++)
                {
                    Button cellButton = new Button();

                    cellButton.Size = new Size(Constants.CELL_SIZE, Constants.CELL_SIZE);
                    cellButton.Location = new Point(rows * (Constants.CELL_SIZE), columns * (Constants.CELL_SIZE));
                    cellButton.Cursor = Cursors.Hand;
                    cellButton.FlatStyle = FlatStyle.Flat;
                    cellButton.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
                    cellButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                    cellButton.Font = new Font(cellButton.Font.Name, cellButton.Font.Size, FontStyle.Bold);
                    cellButton.TabStop = false;
                    cellButton.Click += CellButton_Click;

                    Value[rows].Add(cellButton);
                }
            }
        }

        public bool IsFull()
        {
            for (byte rows = 0; rows < Settings.gridSize; rows++)
            {
                for (byte columns = 0; columns < Settings.gridSize; columns++)
                {
                    if (Value[rows][columns].Text == String.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void ToggleEnabled(bool enabled)
        {
            for (byte rows = 0; rows < Settings.gridSize; rows++)
            {
                for (byte columns = 0; columns < Settings.gridSize; columns++)
                {
                    Value[rows][columns].Enabled = enabled;
                }
            }
        }

        public void Clear()
        {
            for (byte rows = 0; rows < Settings.gridSize; rows++)
            {
                for (byte columns = 0; columns < Settings.gridSize; columns++)
                {
                    Value[rows][columns].Text = String.Empty;
                }
            }
        }

        public void Delete()
        {
            Value.Clear();
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
