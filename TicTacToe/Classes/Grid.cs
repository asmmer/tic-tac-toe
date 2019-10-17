using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe.Classes
{
    public class Grid
    {
        List<Button> grid = new List<Button>();

        public Grid(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Button cellButton = new Button();

                cellButton.Size = new Size(50, 50);
                // Position setting.
                cellButton.Cursor = Cursors.Hand;
                cellButton.Click += CellButton_Click;

                grid.Add(cellButton);
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
