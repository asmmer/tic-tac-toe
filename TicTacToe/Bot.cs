using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    class Bot
    {
        static Random random = new Random();

        public static Point GetAnswer(List<List<Button>> grid)
        {
            Point botAnswer = new Point();

            do
            {
                botAnswer.X = random.Next(grid.Count);
                botAnswer.Y = random.Next(grid.Count);
            }
            while (grid[botAnswer.X][botAnswer.Y].Text != String.Empty);

            return botAnswer;
        }
    }
}
