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

            Classes.Grid _grid = new Classes.Grid(2);

            List<Button> grid = _grid.GetGrid();
            
            foreach (Button cell in grid)
            {
                GridPanel.Controls.Add(cell);
            }
        }

        // Handlers.

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            OpenAboutProgramForm();
        }

        // Methods.

        private void OpenAboutProgramForm()
        {
            new AboutProgramForm().ShowDialog();
        }
    }
}
