using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public class Grid
    {
        List<Button> grid = new List<Button>();

        // Methods.
        public void SetGrid(int gridSize)
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
                ClearGrid();
            }

            for (int rows = 0; rows < gridSize; rows++)
            {
                for (int columns = 0; columns < gridSize; columns++)
                {
                    Button cellButton = new Button();

                    cellButton.Size = new Size(50, 50);
                    cellButton.Location = new Point(rows * 50, columns * 50);
                    cellButton.Cursor = Cursors.Hand;
                    cellButton.FlatStyle = FlatStyle.Flat;
                    cellButton.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
                    cellButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 210, 210);
                    cellButton.TabStop = false;
                    cellButton.Click += CellButton_Click;

                    grid.Add(cellButton);
                }
            }
        }

        public List<Button> GetGrid()
        {
            return grid;
        }

        public void ClearGrid()
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
                
            }
        }
    }
}
