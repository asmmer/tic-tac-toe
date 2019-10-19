using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    class Game
    {
        public bool isStarted = false;

        public int xScore = 0,
                   oScore = 0;

        Panel gridPanel = null;
        Grid grid = null;

        public Game(Panel gridPanel)
        {
            this.gridPanel = gridPanel;
        }

        public void Start()
        {
            isStarted = true;
            SetGrid(Settings.gridSize);
        }

        public void Stop()
        {
            isStarted = false;
        }

        public void ResetValues()
        {
            isStarted = false;
            xScore = 0;
            oScore = 0;
            grid = null;
        }

        private void ClearGrid()
        {
            gridPanel.Controls.Clear();
        }

        private void SetGrid(int gridSize)
        {
            if (gridPanel.Controls.Count > 0)
            {
                ClearGrid();
            }

            if (gridSize < Constants.MIN_GRID_SIZE || gridSize > Constants.MAX_GRID_SIZE)
            {
                MessageBox.Show($"Size is equals - {gridSize}. Need to pick another.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            grid = new Grid(gridSize);

            List<Button> cells = grid.GetGrid();

            foreach (Button cell in cells)
            {
                gridPanel.Controls.Add(cell);
            }
        }
    }
}
