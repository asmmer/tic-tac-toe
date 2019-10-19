using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        // Methods.

        private void ClearGrid()
        {
            GridPanel.Controls.Clear();
        }

        private void CreateGrid(int gridSize)
        {
            if (GridPanel.Controls.Count > 0)
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

            Grid _grid = new Grid(gridSize);

            List<Button> grid = _grid.GetGrid();

            foreach (Button cell in grid)
            {
                GridPanel.Controls.Add(cell);
            }
        }

        private void OpenAboutProgramForm()
        {
            new AboutProgramForm().ShowDialog();
        }

        // Handlers.

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            OpenAboutProgramForm();
        }

        private void SetGridSizeNUD_ValueChanged(object sender, EventArgs e)
        {
            CreateGrid(Convert.ToByte(SetGridSizeNUD.Value));
        }
    }
}
