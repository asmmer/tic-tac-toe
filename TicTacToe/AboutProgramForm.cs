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
    public partial class AboutProgramForm : Form
    {
        public AboutProgramForm()
        {
            InitializeComponent();
        }

        private void SetTheme()
        {
            Visualization.SetTheme(this, Settings.theme, 1);
            Visualization.SetTheme(HowToPlayLabel, Settings.theme, 0);
            Visualization.SetTheme(AuthorLabel, Settings.theme, 0);
        }

        private void AboutProgramForm_Load(object sender, EventArgs e)
        {
            SetTheme();
        }
    }
}
