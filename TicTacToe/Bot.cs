using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class Bot
    {
        private static readonly Random random = new Random();

        public static Point GetAnswer(List<List<Button>> grid, Sign botOrder)
        {
            Point botAnswer = new Point();
            Point emptyCell = new Point();

            byte botCells = 0;
            byte playerCells = 0;

            // ATTACK.

            // Rows.
            for (byte rows = 0; rows < grid.Count; rows++)
            {
                emptyCell = new Point();
                botCells = 0;

                for (byte columns = 0; columns < grid.Count; columns++)
                {
                    if (grid[columns][rows].Text == $"{botOrder}")
                    {
                        botCells++;
                    }
                    else if (grid[columns][rows].Text == string.Empty)
                    {
                        emptyCell.X = columns;
                        emptyCell.Y = rows;
                    }
                }

                if (botCells == grid.Count - 1 &&
                    grid[emptyCell.X][emptyCell.Y].Text == string.Empty)
                {
                    return emptyCell;
                }
            }

            // Columns.
            for (byte rows = 0; rows < grid.Count; rows++)
            {
                emptyCell = new Point();
                botCells = 0;

                for (byte columns = 0; columns < grid.Count; columns++)
                {
                    if (grid[rows][columns].Text == $"{botOrder}")
                    {
                        botCells++;
                    }
                    else if (grid[rows][columns].Text == string.Empty)
                    {
                        emptyCell.X = rows;
                        emptyCell.Y = columns;
                    }
                }

                if (botCells == grid.Count - 1 &&
                    grid[emptyCell.X][emptyCell.Y].Text == string.Empty)
                {
                    return emptyCell;
                }
            }

            // Diagonals checking.
            emptyCell = new Point();
            botCells = 0;

            for (byte rows = 0; rows < grid.Count; rows++)
            {
                if (grid[rows][rows].Text == $"{botOrder}")
                {
                    botCells++;
                }
                else if (grid[rows][rows].Text == string.Empty)
                {
                    emptyCell.X = rows;
                    emptyCell.Y = rows;
                }
            }

            if (botCells == grid.Count - 1 &&
                grid[emptyCell.X][emptyCell.Y].Text == string.Empty)
            {
                return emptyCell;
            }

            emptyCell = new Point();
            botCells = 0;

            for (byte rows = 0; rows < grid.Count; rows++)
            {
                if (grid[rows][grid.Count - rows - 1].Text == $"{botOrder}")
                {
                    botCells++;
                }
                else if (grid[rows][grid.Count - rows - 1].Text == string.Empty)
                {
                    emptyCell.X = rows;
                    emptyCell.Y = grid.Count - rows - 1;
                }
            }

            if (botCells == grid.Count - 1 &&
                grid[emptyCell.X][emptyCell.Y].Text == string.Empty)
            {
                return emptyCell;
            }

            // DEFENCE.

            // Rows.
            for (byte rows = 0; rows < grid.Count; rows++)
            {
                emptyCell = new Point();
                playerCells = 0;

                for (byte columns = 0; columns < grid.Count; columns++)
                {
                    if (grid[columns][rows].Text != $"{botOrder}" &&
                        grid[columns][rows].Text != string.Empty)
                    {
                        playerCells++;
                    }
                    else if (grid[columns][rows].Text == string.Empty)
                    {
                        emptyCell.X = columns;
                        emptyCell.Y = rows;
                    }
                }

                if (playerCells == grid.Count - 1 &&
                    grid[emptyCell.X][emptyCell.Y].Text == string.Empty)
                {
                    return emptyCell;
                }
            }

            // Columns.
            for (byte rows = 0; rows < grid.Count; rows++)
            {
                emptyCell = new Point();
                playerCells = 0;

                for (byte columns = 0; columns < grid.Count; columns++)
                {
                    if (grid[rows][columns].Text != $"{botOrder}" &&
                        grid[rows][columns].Text != string.Empty)
                    {
                        playerCells++;
                    }
                    else if (grid[rows][columns].Text == string.Empty)
                    {
                        emptyCell.X = rows;
                        emptyCell.Y = columns;
                    }
                }

                if (playerCells == grid.Count - 1 &&
                    grid[emptyCell.X][emptyCell.Y].Text == string.Empty)
                {
                    return emptyCell;
                }
            }

            // Diagonals checking.
            emptyCell = new Point();
            playerCells = 0;

            for (byte rows = 0; rows < grid.Count; rows++)
            {
                if (grid[rows][rows].Text != $"{botOrder}" &&
                    grid[rows][rows].Text != string.Empty)
                {
                    playerCells++;
                }
                else if (grid[rows][rows].Text == string.Empty)
                {
                    emptyCell.X = rows;
                    emptyCell.Y = rows;
                }
            }

            if (playerCells == grid.Count - 1 &&
                grid[emptyCell.X][emptyCell.Y].Text == string.Empty)
            {
                return emptyCell;
            }

            emptyCell = new Point();
            playerCells = 0;

            for (byte rows = 0; rows < grid.Count; rows++)
            {
                if (grid[rows][grid.Count - rows - 1].Text != $"{botOrder}" &&
                    grid[rows][grid.Count - rows - 1].Text != string.Empty)
                {
                    playerCells++;
                }
                else if (grid[rows][grid.Count - rows - 1].Text == string.Empty)
                {
                    emptyCell.X = rows;
                    emptyCell.Y = grid.Count - rows - 1;
                }
            }

            if (playerCells == grid.Count - 1 &&
                grid[emptyCell.X][emptyCell.Y].Text == string.Empty)
            {
                return emptyCell;
            }


            // RANDOM ANSWER.
            do
            {
                botAnswer.X = random.Next(grid.Count);
                botAnswer.Y = random.Next(grid.Count);
            }
            while (grid[botAnswer.X][botAnswer.Y].Text != string.Empty);

            return botAnswer;
        }
    }
}
