using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    class Game
    {
        public Sign order;

        private bool isStarted = false;

        int xScore = 0,
            oScore = 0;

        Grid grid = new Grid();

        readonly Random random = new Random();


        public void Start()
        {
            isStarted = true;
            order = (random.Next(2) == 0) ? Sign.X : Sign.O;

            SetGrid();
        }

        private void CellClick()
        {
            if (IsWinCombination())
            {
                SetScore(order);
                return;
            }
            ToggleTurnValue();
        }

        private bool IsWinCombination()
        {
            return false;
        }

        private void ToggleTurnValue()
        {
            order = (order == Sign.X) ? Sign.O : Sign.X;
        }

        public void SetScore(Sign winner)
        {
            if (winner == Sign.X)
            {
                xScore++;
            }
            else if (winner == Sign.O)
            {
                oScore++;
            }
        }

        public void Pause()
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

        private void SetGrid()
        {
            if (grid == null ||
                grid.GetGrid().Count / Settings.gridSize != Settings.gridSize)
            {
                grid.SetGrid(Settings.gridSize);
            }
        }

        public List<Button> GetGrid()
        {
            return grid.GetGrid();
        }

        private void ClearGrid()
        {
            grid.ClearGrid();
        }
    }
}
