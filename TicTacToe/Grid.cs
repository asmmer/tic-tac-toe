using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public class Grid
    {
        List<Button> grid = new List<Button>();

        public Grid(int gridSize)
        {
            SetGrid(gridSize);
        }

        public void SetGrid(int gridSize)
        {
            if (grid.Count > 0)
            {
                grid.Clear();
            }

            for (int rows = 0; rows < gridSize; rows++)
            {
                for (int columns = 0; columns < gridSize; columns++)
                {
                    Button cellButton = new Button();

                    cellButton.Size = new Size(50, 50);
                    cellButton.Location = new Point(rows * 50, columns * 50);
                    cellButton.Cursor = Cursors.Hand;
                    cellButton.Click += CellButton_Click;

                    grid.Add(cellButton);
                }
            }
        }

        public List<Button> GetGrid()
        {
            return grid;
        }

        private void CellButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click!");
        }
    }
}
