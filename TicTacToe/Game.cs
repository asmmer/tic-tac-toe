using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    public class Game
    {
        public Sign order;
        private bool isStarted = false;
        int xScore = 0,
            oScore = 0;

        Grid grid;
        MainForm mainForm;

        readonly Random random = new Random();

        public Game(MainForm mainForm)
        {
            this.mainForm = mainForm;
            grid = new Grid(this);
        }

        public void Start()
        {
            isStarted = true;
            order = (random.Next(2) == 0) ? Sign.X : Sign.O;

            SetGrid();
        }

        public void CellClick()
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
            mainForm.SetTurnValue(order);
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
                grid.Value.Count / Settings.gridSize != Settings.gridSize)
            {
                grid.SetGrid(Settings.gridSize);
            }
        }

        public List<Button> GetGrid()
        {
            return grid.Value;
        }

        public void ClearGrid()
        {
            grid.Clear();
        }

        private void DeleteGrid()
        {
            grid.Delete();
        }
    }
}
