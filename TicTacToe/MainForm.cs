using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        SettingsForm settingsForm = new SettingsForm();
        AboutProgramForm aboutProgramForm = new AboutProgramForm();

        Game game;

        public MainForm()
        {
            InitializeComponent();

            game = new Game(GridPanel);
        }

        // Methods.


        private void OpenSettingsForm()
        {
            settingsForm.ShowDialog();
        }

        private void OpenAboutProgramForm()
        {
            aboutProgramForm.ShowDialog();
        }

        // Handlers.
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            OpenSettingsForm();
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            OpenAboutProgramForm();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            game.Start();
        }
    }
}
